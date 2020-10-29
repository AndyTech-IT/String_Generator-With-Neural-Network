import sqlite3
from sqlite3 import Error, Connection, Cursor

import os
import pickle

'''

'''
network_table: str = 'Neural_Network'
words_table: str = 'Word'
db_path: str = 'db.sqlite3'

def _weight_serialization(weights: list) -> bytes:
    return pickle.dumps(weights)

def _weight_deserialization(serialize_weights: bytes) -> list:
    return pickle.loads(serialize_weights)


def _Execute_Query(Query_Creator):
    def Execute(*args, query_args: tuple = None) -> tuple:
        '''
        Get query from Query_Creator function
        Execute request
        return query_result
        '''
        query: str = Query_Creator(*args)                       

        connection: Connection = sqlite3.connect(db_path)
        cursor: Cursor = connection.cursor()
        if query_args:
            query_result: tuple = cursor.execute(query, query_args).fetchall()
        else:
            query_result: tuple = cursor.execute(query).fetchall()
        connection.commit()
        connection.close()

        return query_result
    return Execute

@_Execute_Query
def _select_(table_name: str, request_condition: str='') -> str:
    '''
    request_condition mast be like 'WHERE ...' or ''
    '''
    query = 'SELECT * FROM {0} {1}'.format(table_name, request_condition)
    return query

@_Execute_Query
def _insert_into_(table_name: str, *col_names: str) -> str:
    columns: str = '('
    values: str = '('

    for name in col_names:
        columns += name+', '
        values += '?, '

    columns = columns[0:-2]+')'
    values = values[0:-2]+')'

    query: str = 'INSERT INTO {0} {1} VALUES {2}'.format(table_name, columns, values)

    return query

@_Execute_Query
def _update_(table_name: str, request_condition: str = '', *update_columns: str) -> str:
    '''
    request_condition mast be like 'WHERE ...' or ''
    '''
    set_sting: str = ''

    for name in update_columns:
        set_sting += '{0} = ?, '.format(name)
    set_sting = set_sting[0:-2]

    query = 'UPDATE {0} SET {1} {2}'.format(table_name, set_sting, request_condition)

    return query

@_Execute_Query
def _delete_(table_name: str, request_condition: str) -> str:
    '''
    request_condition mast be like 'WHERE ...' or ''
    example: _delete_('table', 'WHERE name = ?', query_args=('name',))
    '''
    query = 'DELETE FROM {0} {1}'.format(table_name, request_condition)

    return query

def Create_New_Net(name: str, weights: list):
    serialize_weights: bytes = _weight_serialization(weights)
    names_list: tuple = _select_(network_table, 'WHERE name = ?', query_args=(name,))
    if (not names_list):
        _insert_into_(network_table, 'name', 'weights', query_args=(name, serialize_weights))

def Get_Words_Dict() -> dict:
    words = _select_(words_table)
    return dict(words)

def Get_Nets_List() -> list:
    nets = _select_(network_table)
    return_list = []
    for net in nets:
        return_list.append(net[0])
    return return_list

def Load_Network_Data(name: str) -> dict:
    data: tuple = _select_(network_table, 'WHERE name = ?', query_args=(name,))[0]
    weights = _weight_deserialization(data[1])
    return_dict = {'name': data[0], 'weights': weights}
    return return_dict

def Save_Network(name: str, weights: list):
    serialize_weights = _weight_serialization(weights)
    _update_(network_table, 'WHERE name = ?', 'weights', query_args=(serialize_weights, name))

def Delete_Network(name: str) -> None:
    _delete_(network_table, 'WHERE name = ?', query_args=(name,))
    
if __name__ == "__main__":
    pass