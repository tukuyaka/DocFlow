using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DocFlow.Model
{
    class FileIO
    {
        // Предпологает работу совмесно с ManagerDB, выступая посредником между ОС и СУБД
        // IsExist - Проверяет существование файла по заданому пути
        // GetByteArray - Получает предстовление файла по задоному пути в виде массива байтов
        // SetByteArray - Сохраняет массив байтов в виде файла по заданому пути

        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        public byte[] GetByteArray(string filePath)
        {
            byte[] fileByteArray = File.ReadAllBytes(filePath);
            return fileByteArray;
        }


        // TODO: Возможна проблема сохранения расширения (прописывать расширение в имя?)
        public void SetByteArray(string filePath, byte[] fileByteArray)
        {
            File.WriteAllBytes(filePath, fileByteArray);
        }
    }
}
