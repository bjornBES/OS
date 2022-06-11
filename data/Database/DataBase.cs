using System;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;

namespace BEs.mathF.data
{
    public class DataBase : Base
    {
        static string path = Application.UserAppDataPath + @"\private\Password\data.txt";
        public static string[ ] LT = new string[100];
        public static string[ ] LTSet = new string[100];
        public static int LTSetI;
        public static void LoadData()
        {
            string name = "";
            Object val = "";
            types types = types.none;
            ModTypes modTypes = ModTypes.none;
            int Fun = 0;
            string[ ] text = File.ReadAllText(path).Split(',', '.', ':', ' ');
            LT = text;
            for (int i = 0; i < text.Length; i++)
            {
                int II = i +1;
                if (text[i] == "Name")
                {
                    name = text[II];
                }
                if (text[i] == "Value")
                {
                    val = text[II];
                }
                if (text[i] == "Type")
                {
                    Fun = 0;
                    switch (text[II])
                    {
                        case "Ints":
                            types=types.Ints;
                            break;
                        case "Bool":
                            types=types.Bool;
                            break;
                        case "String":
                            types=types.String;
                            break;
                        case "Float":
                            types=types.Float;
                            break;
                    }
                }
                if (text[i] == "Mod")
                {
                    Fun = 1;
                    switch (text[II])
                    {
                        case "Public":
                            modTypes=ModTypes.Public;
                            break;
                        case "Static":
                            modTypes=ModTypes.Static;
                            break;
                        case "PS":
                            modTypes=ModTypes.PUS;
                            break;
                    }
                }
            }
            if (Fun == 0)
            {
                Set(name, val, types, false);
                Index++;
            }
            else
            {
                SetFun(name, val, types, false, modTypes);
                Index++;
            }
        }
        public static void ResetData()
        {
            string[ ] Text = { "" };
            File.WriteAllLines(path, Text);
            Index = 0;
            for (int i = 0; i < DBaseName.Length; i++)
            {
                DBaseName[i] ="";
                DBaseValues[i] ="";
                DBaseTypes[i] =types.none;
            }
        }
        public static void Set(string name, Object value, types type, bool W)
        {
            DBaseName[Index] = name;
            DBaseValues[Index] = value;
            DBaseTypes[Index] = type;
            string[ ] Text = { File.ReadAllText(path) + " Index:" + Index +
                    ".Type:" + type.ToString() +
                    ".Name:" + name +
                    ".Value:" + value + " "};
            if (W == true)
                File.WriteAllLines(path, Text);
            LTSet[LTSetI]=Text[0];
            LTSetI++;
            Index++;
        }
        public static void SetFun(string name, Object AG, types type, bool W, ModTypes modTypes)
        {
            DBaseName[Index] = name;
            DBaseValues[Index] = AG;
            DBaseTypes[Index] = type;
            DBaseModTypes[Index] = modTypes;
            string[ ] Text = { File.ReadAllText(path) + " Index:" + Index +
                    ".Type:" + type.ToString() +
                    ".Name:" + name +
                    ".AG:" + AG +
                    ".Mod:" + modTypes + " "};
            if (W == true)
                File.WriteAllLines(path, Text);
            Index++;
        }
        public static void SetClass(string name, bool W, ModTypes modTypes)
        {
            DBaseName[Index] = name;
            DBaseModTypes[Index] = modTypes;
            string[ ] Text = { File.ReadAllText(path) + " Index:" + Index +
                    ".Name:" + name +
                    ".Mod:" + modTypes + " "};
            if (W == true)
                File.WriteAllLines(path, Text);
            Index++;
        }
        public static Object Get(string name)
        {
            Object val = 1;
            for (int i = 0; i < DBaseName.Length; i++)
            {
                if (DBaseName[i] == name)
                {
                    val = DBaseValues[i];
                }
            }
            return val;
        }
        public static void DeleteN(string name)
        {
            for (int i = 0; i < DBaseName.Length; i++)
            {
                if (DBaseName[i] == name)
                {
                    Index--;
                    int II = i + 1;
                    DBaseName[i] = "";
                    DBaseValues[i] = "";
                    DBaseTypes[i] = types.none;
                    DBaseName[i]=DBaseName[II];
                    DBaseValues[i] = DBaseValues[II];
                    DBaseTypes[i]=DBaseTypes[II];
                    DBaseName[II] = "";
                    DBaseValues[II] = 0;
                    DBaseTypes[II] = types.none;
                }
            }
        }
        public static void DeleteV(string val)
        {
            for (int i = 0; i < DBaseName.Length; i++)
            {
                if (DBaseName[i] == val)
                {
                    Index--;
                    int II = i + 1;
                    DBaseName[i] = "";
                    DBaseValues[i] = "";
                    DBaseTypes[i] = types.none;
                    DBaseName[i]=DBaseName[II];
                    DBaseValues[i] = DBaseValues[II];
                    DBaseTypes[i]=DBaseTypes[II];
                    DBaseName[II] = "";
                    DBaseValues[II] = 0;
                    DBaseTypes[II] = types.none;
                }
            }
        }
        public static int FindIndex(string valORName, int Over50)
        {
            int Id = -1;
            if (Index > 50)
            {
                if (Over50 != 1)
                {
                    if (Id == -1)
                    {
                        for (int i = 25; i < 50; i++)
                        {
                            if (valORName == DBaseName[i] || valORName == DBaseValues[i].ToString())
                            {
                                Id = i;
                            }
                        }
                        for (int i = 0; i < 25; i++)
                        {
                            if (valORName == DBaseName[i] || valORName == DBaseValues[i].ToString())
                            {
                                Id = i;
                            }
                        }
                    }
                }
                else
                {
                    if (Id == -1)
                    {
                        for (int i = 50; i < 75; i++)
                        {
                            if (valORName == DBaseName[i] || valORName == DBaseValues[i].ToString())
                            {
                                Id = i;
                            }
                        }
                        for (int i = 75; i < DBaseName.Length; i++)
                        {
                            if (valORName == DBaseName[i] || valORName == DBaseValues[i].ToString())
                            {
                                Id = i;
                            }
                        }
                    }
                }
            }
            else
            {
                if (Id == -1)
                {
                    for (int i = 25; i < 50; i++)
                    {
                        if (valORName == DBaseName[i] || valORName == DBaseValues[i].ToString())
                        {
                            Id = i;
                        }
                    }
                    for (int i = 0; i < 25; i++)
                    {
                        if (valORName == DBaseName[i] || valORName == DBaseValues[i].ToString())
                        {
                            Id = i;
                        }
                    }
                }
            }
            return Id;
        }
        public static void NewVal(string Name, Object Val, types type)
        {
            DeleteN(Name);
            Set(Name, Val, type, true);
        }
    }
}
