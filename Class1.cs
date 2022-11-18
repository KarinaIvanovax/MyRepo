using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    enum Stage
    {
        Проект, Исполнение, Закрыт
    }
    internal class Project
    {
        public string DescriptionP { get; set; }
        public DateTime TermP { get; set; }
        public string CustomerP { get; set; }
        public string TeamleadP { get; set; }
        //public Task Tasks { get; set; }
        public Stage StatusP { get; set; }
        public override string ToString()
        {
            return $"Описание проекта: {DescriptionP}\nЗаказчик: {CustomerP}";
        }
        class Task
        {
            public string DescriptionT { get; set; }
            public DateTime TermT { get; set; }
            public string CustomerT { get; set; }
            public string TeamleadT { get; set; }
            public Stage StatusT { get; set; }
            public Report ReportT { get; set; }

        }
        class Report
        {

        }
    }
   

}
