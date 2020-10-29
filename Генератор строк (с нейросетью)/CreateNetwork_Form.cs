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
        \brief Форма ввода имени создаваемой нейросети.
     */
    public partial class CreateNetwork_Form : Form
    {
        readonly string[] NetworksNames; /// Список занятых имен.

        /**
            \brief Открытый атрибут формы, результат диалога. 
            \detail Открывает доступ к выбраннаму имени нейросети.
         */
        public string NetworkName { get { return Name_TextBox.Text; } }

        /**
            \brief Конструктор формы.
            \param[string[]] netNames - Массив имён существующих нейросетей.
         */
        public CreateNetwork_Form(string[] netNames)
        {
            InitializeComponent();
            NetworksNames = netNames;
        }

        /**
            \brief Обработчик нажатия на кнопку "Создать".
            \detail Проверяет введённое имя и закрывает диалоговое окно с кодом "ОК", если имя доступно.
         */
        private void Create_Button_Click(object sender, EventArgs e)
        {
            if (NetworkName == "" || NetworksNames.Contains(NetworkName))
            {
                Validation_Label.Visible = true;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /**
            \brief Обработка нажатия на кнопку "Отмена".
            \detail Закрывает окно с кодом "Cancel".
         */
        private void Cancle_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
