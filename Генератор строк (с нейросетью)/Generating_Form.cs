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
        \brief Форма ввода числа слов в генерируемой строке.
     */
    public partial class Generating_Form : Form
    {
        /**
            \brief Открытый атрибут формы, результат диалога. 
            \detail Предоставляет доступ к указанное длинне строки.
         */
        public int StingLength { get { return (int)Length_NumericUpDown.Value; } }

        /**
            \brief Конструктор формы.
         */
        public Generating_Form()
        {
            InitializeComponent();
        }

        /**
            \brief Обработчик нажатия на кнопку "Далее".
            \detail Закрывает диалоговое окно с кодом "ОК".
         */
        private void Generate_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
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
