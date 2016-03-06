using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestShot
{
    class PresetLoader
    {
        public class TextLayoutPreset
        {
            public int x, y;
            public String fontName;
            public float fontSize;

           // public TextLayoutPreset
        };

        public class ImageLayoutPreset
        {
            public int x, y;
            public int width, height;
        };

        public static void loadPreset()
        {

            string[] splited;
            string line;
            try
            {
                StreamReader file = new StreamReader(presetFileName);
                textPresets = new List<TextLayoutPreset>();
                for (int i = 0; i < TestShotDrawer.TextNum; ++i)
                {
                    line = file.ReadLine();
                    splited = line.Split(',');
                    TextLayoutPreset textPreset = new TextLayoutPreset();
                    textPreset.x = Int32.Parse(splited[1].Replace("\"", ""));
                    textPreset.y = Int32.Parse(splited[2].Replace("\"", ""));
                    textPreset.fontName = splited[3].Replace("\"", "");
                    textPreset.fontSize = Int32.Parse(splited[4].Replace("\"", ""));
                    textPresets.Add(textPreset);
                }
                imagePresets = new List<ImageLayoutPreset>();
                for (int i = 0; i < TestShotDrawer.ImageNum; ++i)
                {
                    line = file.ReadLine();
                    splited = line.Split(',');
                    ImageLayoutPreset imagePreset = new ImageLayoutPreset();
                    imagePreset.x = Int32.Parse(splited[1].Replace("\"", ""));
                    imagePreset.y = Int32.Parse(splited[2].Replace("\"", ""));
                    imagePreset.width = Int32.Parse(splited[3].Replace("\"", ""));
                    imagePreset.height = Int32.Parse(splited[4].Replace("\"", ""));
                    imagePresets.Add(imagePreset);
                }
                file.Close();
            }
            catch (Exception e)
            {
                throw new Exception("preset.csv 불러오기에 실패했습니다.");
            }
            //return presets;
        }

        public static void savePresets()
        {
            if (textPresets != null && imagePresets != null)
            {
                try
                {
                    StreamWriter file = new StreamWriter(presetFileName);
                    string line;
                    for (int i = 0; i < TestShotDrawer.TextNum; ++i)
                    {
                        line = "," + textPresets[i].x + "," + textPresets[i].y +
                            "," + textPresets[i].fontName + "," + textPresets[i].fontSize;
                        file.WriteLine(line);
                    }
                    for (int i = 0; i < TestShotDrawer.ImageNum; ++i)
                    {
                        line = "," + imagePresets[i].x + "," + imagePresets[i].y +
                            "," + imagePresets[i].width + "," + imagePresets[i].height;
                        file.WriteLine(line);
                    }
                    file.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        public static List<TextLayoutPreset> getTextPresets()
        {
            return PresetLoader.textPresets;
        }

        public static List<ImageLayoutPreset> getImagePresets()
        {
            return PresetLoader.imagePresets;
        }

        public static void setTextPresets(List<TextLayoutPreset> textPresets)
        {
            if (textPresets != null)
                PresetLoader.textPresets = textPresets;
        }

        public static void setImagePresets(List<ImageLayoutPreset> imagePresets)
        {
            if (imagePresets != null)
                PresetLoader.imagePresets = imagePresets;
        }

        private static readonly string presetFileName = "preset.csv";

        private static List<TextLayoutPreset> textPresets = null;
        private static List<ImageLayoutPreset> imagePresets = null;
    }
}
