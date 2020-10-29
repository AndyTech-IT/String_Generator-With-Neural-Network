#!/usr/bin/env python
# -*- coding: utf-8 -*-
import numpy as np

import db_script

class NeuronNet:
    def __init__(self, size=None, name='test', weights: list = None):
        if size is None:
            size = [32, 32, 32]
        if weights:
            size = []
            for layer in weights:
                size.append(len(layer))
        self.name = name
        self.size = size
        self.layers = len(size) - 1
        self.syn = []
        self.train_data = []
        self.train_data_results = []
        if weights:
            self.syn = weights
        else:
            for layer in range(self.layers):
                self.syn.append(2 * np.random.random((size[layer], size[layer + 1])) - 1)
        pass

    def calc(self, data):
        for layer in self.syn:
            data = 1 / (1 + np.exp(-(np.dot(data, layer))))
        return data
        pass

    def add_train_data(self, train_data=None, result_data=None, mode='single'):
        if result_data is None:
            result_data = []
        if train_data is None:
            train_data = []
        if mode == 'single':
            self.train_data.append(train_data)
            self.train_data_results.append(result_data)
        elif mode == 'array':
            for data in train_data:
                self.train_data.append(data)
            for data in result_data:
                self.train_data_results.append(data)
        pass

    def training(self):
        train_data = np.array(self.train_data)
        results = np.array(self.train_data_results)
        for i in range(10):
            data = []
            dat = train_data
            data.append(dat)
            index = 0
            for layer in self.syn:
                dat = 1 / (1 + np.exp(-(np.dot(dat, layer))))
                data.append(dat)
                index += 1
            layer_delta = (results - dat) * (dat * (1 - dat))
            data.pop(-1)
            index -= 1
            for result in data[-1::-1]:
                delta = layer_delta.dot(self.syn[index].T)
                self.syn[index] += result.T.dot(layer_delta)
                layer_delta = delta * (result * (1 - result))
                index -= 1


def Create_New_Network(name: str) -> None:
    size = [101, 100, 100]
    net = NeuronNet(size, name)
    db_script.Create_New_Net(name, net.syn)

def Generate_String(name: str, length: int) -> str:
    data = db_script.Load_Network_Data(name)
    name, weights = data['name'], data['weights']
    net = NeuronNet(name=name, weights=weights)
    words_dict: dict = db_script.Get_Words_Dict()
    string: str = ''
    data = [0.01]*101

    for step in range(length):
        net_values: np.ndarray = net.calc(data)
        
        net_select = net_values.argmax()
        data = [0.01]*101
        data[net_select] = 0.9
        data[-1] = step/10

        word = words_dict[net_select]
        string += word+' '

    string = '{0}{1}.'.format(string[0].upper(), string[1:-1])
    return string

def Train_Network(name: str, input_words: str, result_words: str = None) -> None:
    data = db_script.Load_Network_Data(name)
    name, weights = data['name'], data['weights']
    net = NeuronNet(name=name, weights=weights)
    if result_words:
        input_list, result_list = input_words.split(' '), result_words.split(' ')
    else:
        string_list = input_words.split(' ')
        input_list = ['*'] + string_list
        result_list = string_list + ['*']
    
    print(input_list, result_list)

    words_dict = db_script.Get_Words_Dict()

    for i in range(len(input_list)):
        if input_list[i] == '*':
            input_key = 0
        else:
            input_key = Get_Word_Key(input_list[i], words_dict)

        if result_list[i] == '*':
            result_key = 0
        else:
            result_key = Get_Word_Key(result_list[i], words_dict)

        input_data, result_data = [0.1]*101, [0.1]*100

        input_data[input_key] = 0.9
        input_data[-1] = i/10
        result_data[result_key] = 0.9


        net.add_train_data(input_data, result_data)
    net.training()
    db_script.Save_Network(name, net.syn)

def Get_Word_Key(word: str, words_dict: dict) -> int: 
    for key in words_dict.keys():
        if words_dict[key] == word:
            return key
    print(word)

if __name__ == "__main__":
    import sys
    args: list = sys.argv[1:]
    if args:
        if args[0].upper() == 'GET_WORDS_DICT':
            words = db_script.Get_Words_Dict().values()
            print_str = ''
            for word in words:
                print_str += word+'*'
            print(print_str[:-1])

        elif args[0].upper() == 'GET_NETS_LIST':
            nets = db_script.Get_Nets_List()
            print_str = ''
            for net in nets:
                print_str += net+'*'
            print(print_str[:-1])

        elif args[0].upper() == 'CREATE_NET' and len(args) > 1:
            try:
                name = args[1]
                Create_New_Network(name)
                print('Успешно создана нейросеть - '+name)
            except:
                print('ERROR!')

        elif args[0].upper() == 'DELETE_NET' and len(args) > 1:
            try:
                name = args[1]
                db_script.Delete_Network(name)
                print('Успешно удалена нейросеть - '+name)
            except:
                print('ERROR!')

        elif args[0].upper() == 'GENERATE_STRING' and len(args) > 2:
            name = args[1]
            length = int(args[2])
            print(Generate_String(name, length))
            
        elif args[0].upper() == 'TRAIN_NETWORK' and len(args) > 2:
            if len(args) > 3:
                word2 = args[3]
            name, word1, word2 = args[1], args[2], None
            Train_Network(name, word1, word2)
            print('Complit')
        else:
            print('ERROR!')
            
