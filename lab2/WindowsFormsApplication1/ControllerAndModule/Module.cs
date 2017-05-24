using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControllerAndModel
{
    public class FileContent//представление (view)
    {
        public string path { get; set; }
        public Stream Content { get; set; }
        public string Text { get; set; }
    }

    public class Reader : IFileResult
    {
        public Stream SuccesResult(string Path)
        {
            var fc = new FileContent();
            if (Path != null)
            {
                fc.Content = new FileStream(Path, FileMode.Open);
                return fc.Content;
            }
            else
                return null;
        }

        public string ErrorResult(string Path)
        {
            var fc = new FileContent();
            if (Path == null)
            {
                string message = "Ошибка.Не указан путь.";
                return message;
            }
            else
                return null;
        }
    }
    public class Writer : IFileResult
    {
        public Stream SuccesResult(string Path)
        {
            var fc = new FileContent();

            if (Path != null)
            {
                fc.Content = new FileStream(Path, FileMode.Create);
                return fc.Content;
            }
            else
                return null;
        }

        public string ErrorResult(string Path)
        {
            var fc = new FileContent();
            if (fc.path == null)
            {
                string message = "Ошибка.Не указан путь.";
                return message;
            }
            else
                return null;
        }
    }

    interface IFileResult
    {
        Stream SuccesResult(string Path);
        string ErrorResult(string Path);
    }
}
