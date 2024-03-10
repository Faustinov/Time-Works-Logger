using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    internal class MainFormModel
    {
        /// <summary>
        /// Общее время. Указывает рабочий день.
        /// </summary>
        public string GeneralDateTime { get; set; }
        /// <summary>
        /// Сколько нужно отработать.
        /// </summary>
        public DateTime FullWorkTime { get; set; }
        /// <summary>
        /// Оставшееся рабочее время.
        /// </summary>
        public DateTime RemainingWorkTime { get; set; }
        /// <summary>
        /// Время списанное на таски.
        /// </summary>
        public List<DateTime> SpentTimes { get; set; }
        /// <summary>
        /// Существует ли JSON файл в директории для извлечения/записи данных.
        /// </summary>
        public bool ExistData { get; set; }
    }
}
