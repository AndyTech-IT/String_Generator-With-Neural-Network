using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Генератор_строк__с_нейросетью_
{
    /*!
        \brief Форма выбора имени нейросети.
     */
    public partial class SelectNetwork_Form : Form
    {
        /**
            \brief Открытый атрибут формы, результат диалога. 
            \detail Открывает доступ к выбраннаму имени нейросети.
         */
        public string NetName { get { return NetName_ComboBox.Text.Split(new char[]{ '\n', '\t', '\r' })[0]; } }
        /**
            \brief Конструктор формы
            \param[string[]] netNames - Массив имён существующих нейросетей.
         */
        public SelectNetwork_Form(string[] netNames)
        {
            InitializeComponent();
            NetName_ComboBox.Items.AddRange(netNames);
        }

        /**
            \brief Обработчик нажатия на кнопку "Выбрать".
            \detail Проверяет введённое имя и закрывает диалоговое окно с кодом "ОК", если выбранная нейросеть существует.
         */
        private void Select_Button_Click(object sender, EventArgs e)
        {
            if (NetName_ComboBox.Items.Contains(NetName_ComboBox.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                NetName_ComboBox.Select();
        }

        /**
            \brief Обработчик нажатия на кнопку "Отмена".
            \detail Закрывает диалоговое окно с кодом "Cancel".
         */
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
