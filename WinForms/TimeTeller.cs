using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinForms
{
    /// <summary>
    /// Счётчик времени
    /// </summary>
    internal class TimeTeller
    {
        private readonly DateTime _time;
        private MainFormModel _model;
        private const string PATH = "DataJson";
        public TimeTeller(DateTime time, MainFormModel model)
        {
            _time = time;
            _model = model;
        }
        public async Task DataHandlerAsync()
        {
            var newPath = parseRelativePath();

            if (File.Exists(newPath))
            {
                using (var fileStream = new FileStream(newPath, FileMode.Open))
                    _model = await JsonSerializer.DeserializeAsync<MainFormModel>(fileStream);
            }
            else
            {
                _model.ExistData = true;
                Directory.CreateDirectory("DataJson");
                using (var fileStream = new FileStream(newPath, FileMode.Create))
                    await JsonSerializer.SerializeAsync<MainFormModel>(fileStream, _model);
            }
        }

        private string parseRelativePath() => PATH + $"\\{_time.ToString("dd.MM.yyyy")}.json";
    }
}
