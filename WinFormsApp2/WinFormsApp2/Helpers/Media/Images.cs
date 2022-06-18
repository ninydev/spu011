using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Helpers.Media
{
    public class Images
    {
        string pathToSource;

        string pathToStorage;
        string collectionName;
        string fileName;
        public Images(string pathToSource, string CollectionName )
        {
            this.pathToSource = pathToSource;
            this.collectionName = CollectionName;

            // Путь к хранилищу
            this.pathToStorage = Config.App.Storage_Path;

            // Дать уникальное имя новому файлу
            fileName = Guid.NewGuid().ToString();
        }

        public void ConvertTo()
        {

        }

        public string MoveToStorage()
        {
            var to = CheckDirs();
            to += "\\" + fileName + ".png"; // TODO сейчас сменим

            Bitmap img = new Bitmap(this.pathToSource);
            Image resize = new Bitmap(img, new Size(120,120));
            resize.Save(to, ImageFormat.Png);

            // File.Copy(this.pathToSource, to, true);
            return to;
        }

        /// <summary>
        /// Проверяет наличие необходимой папки
        /// </summary>
        /// <returns>путь к папке</returns>
        private string CheckDirs()
        {
            var to = pathToStorage + "\\" + collectionName;

            // Если нет папки для хранения данной коллекции - создать ее
            if (!Directory.Exists(to))
            {
                Directory.CreateDirectory(to);
            }

            DateTime date = DateTime.Now;

            to += "\\" + date.Year.ToString();
            if (!Directory.Exists(to))
            {
                Directory.CreateDirectory(to);
            }

            to += "\\" + date.Month.ToString();
            if (!Directory.Exists(to))
            {
                Directory.CreateDirectory(to);
            }

            return to;

        }
    }
}
