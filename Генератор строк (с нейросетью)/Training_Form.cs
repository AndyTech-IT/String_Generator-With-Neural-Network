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
        \brief Форма генерации обучающих данных для нейросетей.
     */
    public partial class Training_Form : Form
    {
        /**
            \brief Отрытый атрибут формы, резульать диалога.
            \detail По успешному завершению диалога, будет хранить отформатированную обучающую строку.
         */
        public string TrainingArguments_String { get; private set; }

        /**
            \brief Отрытый атрибут формы, резульать диалога.
            \detail По успешному завершению диалога, будет хранить имена обучаемых нейросетей.
         */
        public string[] TrainingNetworks { get; private set; }

        /**
            \brief Список для хранения известных нейросетям слов.
         */
        List<string> Words_List;

        /**
            \brief Буферная переменная.
         */
        string Buf;

        /**
            \brief Конструктор формы.
            \param[string[]] netsNames - Массив имён нейросетей.
            \param[string[]] words - Массив слов, известных нейросети.
         */
        public Training_Form(string[] netsNames, string[] words)
        {
            InitializeComponent();
            Nets_CheckedListBox.Items.AddRange(netsNames);
            Words_List = new List<string>(words);
        }

        /**
            \brief Функция проверки выбора нейросетей.
            \detail Проверяет наличие отмеченых имён нейросетей, сохраняет их в "TrainingNetworks". Возвращает истину, если выброно хотябы одно имя.
         */
        bool CheckSelectionNetwork()
        {
            int count = Nets_CheckedListBox.CheckedItems.Count;
            if (count != 0)
            {
                TrainingNetworks = new string[count];
                for (int i = 0; i < count; i++)
                {
                    string name = Nets_CheckedListBox.CheckedItems[i].ToString().Split(new char[] { '\n', '\r', '\t'})[0];
                    TrainingNetworks[i] = name;
                }    
                    
                return true;
            }

            return false;
        }

        /**
            \brief Обработчик нажатия на кнопку "Обучить 1".
            \detail Если "CheckSelectionNetwork" возвращает истину и текстовое поле "Training_RichTextBox" содержит текст, сохраняет его в "TrainingArguments_String" окружив символами '"', а после закрывает диалог с кодом "ОК".
         */
        private void Train_Button1_Click(object sender, EventArgs e)
        {
            if (Training_RichTextBox.Text != "" && CheckSelectionNetwork())
            {
                DialogResult = DialogResult.OK;
                TrainingArguments_String = '\"' + Training_RichTextBox.Text + '\"';
                Close();
            }
            else
                Training_RichTextBox.Select();
        }

        /**
            \brief Обработчик нажатия на кнопку "Обучить 2".
            \detail Если "CheckSelectionNetwork" возвращает истину, проверяет "Training_ListBox1" и "Training_ListBox2" в них должно быть одинаковое число слов, отличное от 0. Формирует "TrainingArguments_String" в виде: "* {слова из Training_ListBox1}" "{слова из Training_ListBox2} *", и закрывает окно с кодом "ОК".
         */
        private void Train_Button2_Click(object sender, EventArgs e)
        {
            if (Training_ListBox1.Items.Count == Training_ListBox2.Items.Count && Training_ListBox1.Items.Count != 0 && CheckSelectionNetwork())
            {
                DialogResult = DialogResult.OK;

                TrainingArguments_String = "\"*";
                foreach (string word in Training_ListBox1.Items)
                    TrainingArguments_String += ' ' + word;
                TrainingArguments_String += "\" \"";

                foreach (string word in Training_ListBox2.Items)
                    TrainingArguments_String += ' ' + word;
                TrainingArguments_String += " *\"";

                Close();
            }
            else
                Training_ListBox1.Select();
        }

        /**
            \brief Обрабатывает нажатие на кнопку "Отмена".
            \detail Закрывает окно с кодом "Cancel".
         */
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /**
            \brief Обработка нажатия на "Training_ListBox1" и "Training_ListBox1".
            \todo Доработать в следующей версии.
         */
        private void Training_ListBox_Click(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            listBox.Items.Add("");
        }

        /**
            \brief Обработка события изменения текста для "Training_RichTextBox".
            \detail Автомотическое дописывание слов из списка "Words_List".
         */
        private void Training_RichTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox textBox = (RichTextBox)sender;
            string text = textBox.Text;
            string[] words = text.Split(' ');
            string word = words.Last();
            string parce_word = Words_List.Find(w => w.StartsWith(word));

            if (words.Length > 1)
            {
                string test_word = words[words.Length - 2];
                if (!Words_List.Contains(test_word) && test_word != "")
                {
                    int start_pos = text.Length;
                    textBox.Select(start_pos, -1 * (test_word.Length + 1));
                    return;
                }
            }

            if (parce_word != null && word != "" && word != Buf)
            {
                int start_pos = text.Length - word.Length;
                text = text.Substring(0, start_pos) + parce_word;
                textBox.Text = text;
                Buf = word;

                int end_pos = start_pos + parce_word.Length;
                int len = word.Length - parce_word.Length;
                textBox.Select(end_pos, len);
            }
        }
    }
}
