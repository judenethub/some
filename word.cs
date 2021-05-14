using System;
using System.IO;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;
namespace Learninig
{
    class Program
    {

        static void Main(string[] args)
        {
              Class_3 class_3 = new Class_3("Нина Сергеевна", 100000);
            
            class_3.Payment_Ilya = 35000;
            class_3.Payment_Kolya = 65000;
            class_3.Payment_Misha = 35000;
            class_3.Payment_Vasya = 45000;
            var qwe = new Word.Application();
            qwe.Visible = true;
            var doc = qwe.Documents.Add();
            var r = doc.Range();
            r.Text = "This is Doc File";
            doc.SaveAs2("my_doc_file");




            //using (var asd = new StreamWriter(word_doc))
            //{
            //    asd.WriteLine($"взнос Ильи  - {class_3.Payment_Ilya}");
            //    asd.WriteLine($"взнос Коли  - {class_3.Payment_Kolya}");
            //    asd.WriteLine($"взнос Миши  - {class_3.Payment_Misha}");
            //    asd.WriteLine($"взнос Васи  - {class_3.Payment_Vasya}");
            //}   

            Console.ReadLine();
        }
    }
}
