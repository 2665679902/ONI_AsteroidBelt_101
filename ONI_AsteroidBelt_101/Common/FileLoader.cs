using ONI_AsteroidBelt_101.Loger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONI_AsteroidBelt_101.Common
{
    internal static class FileLoader
    {
        public static string ModParh { get; private set; }


        private static Dictionary<string, string> fileLoaded;

        public static void Load(string modPath)
        {
            ModParh = modPath;
            fileLoaded = new Dictionary<string, string>();
        }

        public static void WriteIn(string SourseDirectory, string fileName, string content)
        {
            SourseDirectory = Path.Combine(ModParh, SourseDirectory);

            string filePath = Path.Combine(SourseDirectory, fileName);

            File.WriteAllText(filePath, content);

        }

        public static void LoadFile(string SourseDirectory, string TargetDirectory)
        {
            SourseDirectory = Path.Combine(ModParh, SourseDirectory);

            TargetDirectory = Path.Combine(Directory.GetCurrentDirectory(), TargetDirectory);

            CopyTo(SourseDirectory, TargetDirectory);
        }

        public static void Remove(string SourseDirectory)
        {
            SourseDirectory = Path.Combine(ModParh, SourseDirectory);

            Delete(SourseDirectory);

            Log.Debug($"Remove files in {SourseDirectory}");

        }

        private static void Delete(string SourseDirectory)
        {
            foreach (var file in Directory.GetFiles(SourseDirectory))
            {
                string name = Path.GetFileName(file);

                if (fileLoaded.ContainsKey(name))
                {
                    if (File.Exists(fileLoaded[name]))
                        File.Delete(fileLoaded[name]);

                    fileLoaded.Remove(name);

                }

            }

        }

        private static void CopyTo(string SourseDirectory, string TargetDirectory)
        {
            foreach (var file in Directory.GetFiles(SourseDirectory))
            {
                string name = Path.GetFileName(file);


                if (File.Exists(Path.Combine(TargetDirectory, name)))
                    File.Delete(Path.Combine(TargetDirectory, name));

                File.Copy(file, Path.Combine(TargetDirectory, name));

                fileLoaded.Add(name, Path.Combine(TargetDirectory, name));

            }
        }


    }
}
