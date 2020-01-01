using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace UsefulMethods
{
  public class FunctionsFiles
  {
    public static void SetManyAttributes(string cheminFichier, params FileAttributes[] listeAttributs)
    {
      foreach (FileAttributes item in listeAttributs)
      {
        SetAttributesEnumere(cheminFichier, item);
      }
    }

    public static void RemoveManyAttributes(string cheminFichier, params FileAttributes[] listeAttributs)
    {
      foreach (FileAttributes item in listeAttributs)
      {
        RemoveAttributes(cheminFichier, item);
      }
    }

    public static void SetAttributesEnumere(string chemin, FileAttributes attributs)
    {
      File.SetAttributes(chemin, File.GetAttributes(chemin) | attributs);
    }

    public static void RemoveAttributes(string chemin, FileAttributes attributesToRemove)
    {
      File.SetAttributes(chemin, File.GetAttributes(chemin) & ~attributesToRemove);
    }

    public static FileAttributes GetRemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
    {
      return attributes & ~attributesToRemove;
    }

    public static void SetAttributes(string chemin, FileAttributes attributs)
    {
      File.SetAttributes(chemin, attributs);
    }

    public static string GetAttributes(string chemin)
    {
      return File.GetAttributes(chemin).ToString();
    }

    public static void SetCreationTime(string chemin, DateTime date)
    {
      File.SetCreationTime(chemin, date);
    }

    public static void SetLastAccessTime(string chemin, DateTime date)
    {
      File.SetLastAccessTime(chemin, date);
    }

    public static DateTime GetCreationTime(string chemin)
    {
      return File.GetCreationTime(chemin);
    }

    public static DateTime GetLastAccessTime(string chemin)
    {
      return File.GetLastAccessTime(chemin);
    }

    public static DateTime GetLastAccessTimeUtc(string chemin)
    {
      return File.GetLastAccessTimeUtc(chemin);
    }

    public static void ReadAndDisplayInConsole(string chemin)
    {
      Action<string> display = Console.WriteLine;
      string[] lines = File.ReadAllLines(chemin);
      foreach (string line in lines)
      {
        display(line);
      }

      display(string.Empty);
    }

    public static bool Deletefile(string filePath)
    {
      if (!File.Exists(filePath))
      {
        return false;
      }

      File.Delete(filePath);
      return true;
    }

    public static void CopyFile(string sourcefile, string destFile, bool overwrite = false)
    {
      File.Copy(sourcefile, destFile, overwrite);
    }

    public static bool MoveFile(string sourcefile, string destFile)
    {
      if (File.Exists(destFile))
      {
        return false;
      }

      File.Move(sourcefile, destFile);
      return true;
    }

    public static void WriteDataArray(string filePath, string[] dataArray)
    {
      if (File.Exists(filePath))
      {
        File.AppendAllLines(filePath, dataArray);
      }
      else
      {
        File.WriteAllLines(filePath, dataArray);
      }
    }

    public static void WriteData(string filePath, string stringData)
    {
      if (File.Exists(filePath))
      {
        File.AppendAllText(filePath, stringData);
      }
      else
      {
        File.WriteAllText(filePath, stringData);
      }
    }

    public static void WriteByteArray(string filePath, byte[] byteArray)
    {
      File.WriteAllBytes(filePath, byteArray);
    }

    public static void CreateFile(string filePath, string stringData = " ")
    {
      File.Create(filePath, stringData.Length);
    }

    public static bool FileRename(string file1, string file2)
    {
      bool result = false;
      try
      {
        File.Move(file1, file2);
        result = true;
      }
      catch (Exception)
      {
        result = false;
      }

      return result;
    }

    public static string GenerateUniqueFileName(string fileName)
    {
      string result = string.Empty;
      if (!File.Exists(fileName))
      {
        return fileName;
      }

      int fileNumber = 1;
      result = AddAtTheEndOfFileName(fileName, fileNumber.ToString(CultureInfo.InvariantCulture));
      while (File.Exists(result))
      {
        fileNumber++;
        result = AddAtTheEndOfFileName(fileName, fileNumber.ToString(CultureInfo.InvariantCulture));
      }

      return result;
    }

    private static string IncreaseFileName(string fileName)
    {
      int fileNumber = 1;
      string result = AddAtTheEndOfFileName(fileName, fileNumber.ToString(CultureInfo.InvariantCulture));
      while (File.Exists(result))
      {
        fileNumber++;
        result = AddAtTheEndOfFileName(fileName, fileNumber.ToString(CultureInfo.InvariantCulture));
      }

      return result;
    }

    private static string AddAtTheEndOfFileName(string fileName, string textToBeAdded)
    {
      const string backslash = "\\";
      string result = GetDirectoryFileNameAndExtension(fileName)[0] + backslash
                                 + GetDirectoryFileNameAndExtension(fileName)[1]
                                 + textToBeAdded
                                 + GetDirectoryFileNameAndExtension(fileName)[2];
      return result;
    }

    private static string[] GetDirectoryFileNameAndExtension(string filePath)
    {
      string directory = Path.GetDirectoryName(filePath);
      string fileName = Path.GetFileNameWithoutExtension(filePath);
      string extension = Path.GetExtension(filePath);

      return new[] { directory, fileName, extension };
    }

    public static void CreateDirectory(string directory)
    {
      Directory.CreateDirectory(directory);
    }

    public static bool DeleteDirectory(string directory)
    {
      bool result = false;
      if (Directory.Exists(directory))
      {
        // check for subdirectories and files within
        string[] files = Directory.GetFiles(directory);
        if (files.Length == 0)
        {
          try
          {
            Directory.Delete(directory);
            result = true;
          }
          catch (Exception)
          {
            result = false;
          }
        }
        else
        {
          // TODO delete subdirectories
          foreach (var file in files)
          {
            try
            {
              File.Delete(file);
            }
            catch (Exception)
            {
              result = false;
            }
          }

        }
      }

      return result;
    }

    public static void CleanDirectory(string tempDirectory)
    {
      Directory.Delete(tempDirectory);
    }

    public static void CreateFile(string filename)
    {
      File.Create(filename);
    }

    public static long FileGetSize(string filePath)
    {
      try
      {
        return File.Exists(filePath) ? new FileInfo(filePath).Length : 0;
      }
      catch (Exception)
      {
        return -1;
      }
    }

    public static string ChooseOneFile(string filter = "All files (*.*)|*.*")
    {
      string result = string.Empty;
      FileDialog fd = new OpenFileDialog();
      fd.Filter = filter;
      if (fd.ShowDialog() == DialogResult.OK)
      {
        result = fd.FileName;
      }

      return result;
    }

    public static string ChooseDirectory()
    {
      string result = string.Empty;
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        result = fbd.SelectedPath;
      }

      return result;
    }

    public static void CreateNewFile(string updateScript)
    {
      StreamWriter sw = new StreamWriter(updateScript, false, Encoding.UTF8);
      sw.Close();
    }

    public static List<FileInfo> SearchFiles(List<string> pattern)
    {
      List<FileInfo> files = new List<FileInfo>();

      foreach (DriveInfo drive in DriveInfo.GetDrives().Where(drive => drive.DriveType != DriveType.CDRom))
      {
        var dirs = from dir in drive.RootDirectory.EnumerateDirectories()
                   select new { ProgDir = dir };
        foreach (var di in dirs)
        {
          try
          {
            foreach (string file in pattern)
            {
              foreach (var fi in di.ProgDir.EnumerateFiles(file, SearchOption.AllDirectories))
              {
                try
                {
                  files.Add(fi);
                }
                catch (UnauthorizedAccessException) { } // handle accordingly
                catch (Exception) { } // handle accordingly
              }
            }
          }
          catch (UnauthorizedAccessException) { } // handle accordingly
          catch (Exception) { } // handle accordingly
        }
      }

      return files;
    }

    public static List<string> GetSubfoldersAndFiles(DirectoryInfo directoryInfo, int depth)
    {
      List<string> result = new List<string>();
      foreach (FileInfo fileInfo in directoryInfo.GetFiles())
      {
        result.Add(fileInfo.FullName);
      }

      if (depth > 0)
      {
        foreach (DirectoryInfo subDi in directoryInfo.GetDirectories())
        {
          result.AddRange(GetSubfoldersAndFiles(subDi, depth - 1).ToArray());
        }
      }

      return result;
    }

    public static Tuple<List<string>, List<string>> GetFilesAndFolders(string root, int depth)
    {
      var folders = new List<string>();
      var files = new List<string>();
      try
      {
        foreach (var directory in Directory.EnumerateDirectories(root))
        {
          folders.Add(directory);
          if (depth > 0)
          {
            var result = GetFilesAndFolders(directory, depth - 1);
            folders.AddRange(result.Item1);
            files.AddRange(result.Item2);
          }
        }
      }
      catch (Exception) { }
      files.AddRange(Directory.EnumerateFiles(root));

      return new Tuple<List<string>, List<string>>(folders, files);
    }

    public static IList<string> GetFilesToDepth(string path, int depth)
    {
      var files = Directory.EnumerateFiles(path).ToList();

      if (depth > 0)
      {
        var folders = Directory.EnumerateDirectories(path);

        foreach (var folder in folders)
        {
          files.AddRange(GetFilesToDepth(folder, depth - 1));
        }
      }

      return files;
    }

    public static List<DriveInfo> GetAllDrives(DriveType[] excludeDriveTypeList)
    {
      List<DriveInfo> result = new List<DriveInfo>();
      try
      {
        foreach (DriveInfo drive in DriveInfo.GetDrives())
        {
          bool addingDrive = true;
          foreach (var excludeDriveType in excludeDriveTypeList)
          {
            if (excludeDriveType == drive.DriveType)
            {
              addingDrive = false;
              break;
            }
          }

          if (addingDrive)
          {
            result.Add(drive);
          }
        }
      }
      catch (Exception) { }
      return result;
    }

    public static IEnumerable<string> GetAllDirectories(string path, string pattern = "*",
      SearchOption searchOption = SearchOption.TopDirectoryOnly)
    {
      List<string> result = new List<string>();
      if (!Directory.Exists(path))
      {
        return result;
      }

      bool complete = false;
      do
      {
        try
        {
          foreach (var directory in Directory.EnumerateDirectories(path, pattern, searchOption))
          {
            result.Add(directory);
            Application.DoEvents();
          }
          complete = true;
        }
        catch (UnauthorizedAccessException) { complete = false; }
        catch (Exception) { complete = false; }
      } while (!complete);

      return result;
    }

    public static IEnumerable<DirectoryInfo> GetDirs(string rootFolderPath)
    {
      DirectoryInfo rootDir = new DirectoryInfo(rootFolderPath);
      yield return rootDir;

      foreach (DirectoryInfo dir in rootDir.GetDirectories("*", SearchOption.AllDirectories))
      {
        yield return dir;
      }
    }

    public static string Serialize<T>(T value)
    {
      if (value == null)
      {
        return null;
      }

      XmlSerializer serializer = new XmlSerializer(typeof(T));
      XmlWriterSettings settings = new XmlWriterSettings
      {
        Encoding = new UnicodeEncoding(false, false),
        Indent = false,
        OmitXmlDeclaration = false
      };

      using (StringWriter textWriter = new StringWriter())
      {
        using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
        {
          serializer.Serialize(xmlWriter, value);
        }

        return textWriter.ToString();
      }
    }

    public static T Deserialize<T>(string xml)
    {
      if (string.IsNullOrEmpty(xml))
      {
        return default(T);
      }

      XmlSerializer serializer = new XmlSerializer(typeof(T));
      XmlReaderSettings settings = new XmlReaderSettings();

      using (StringReader textReader = new StringReader(xml))
      {
        using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
        {
          return (T)serializer.Deserialize(xmlReader);
        }
      }
    }

    /// <summary>
    /// Remove illegal XML characters from a string.
    /// </summary>
    public static string SanitizeXmlString(string xml)
    {
      // TODO write unit tests for this method
      if (xml == null)
      {
        throw new ArgumentNullException("xml");
      }

      StringBuilder buffer = new StringBuilder(xml.Length);

      foreach (char c in xml)
      {
        if (IsLegalXmlChar(c))
        {
          buffer.Append(c);
        }
      }

      return buffer.ToString();
    }

    /// <summary>
    /// Whether a given character is allowed by XML 1.0.
    /// </summary>
    public static bool IsLegalXmlChar(int character)
    {
      return
      character == 0x9 /* == '\t' == 9   */          ||
      character == 0xA /* == '\n' == 10  */          ||
      character == 0xD /* == '\r' == 13  */          ||
      character >= 0x20 && character <= 0xD7FF ||
      character >= 0xE000 && character <= 0xFFFD ||
      character >= 0x10000 && character <= 0x10FFFF;
    }

    public static List<string> GetFilesFileteredBySize(DirectoryInfo directoryInfo, long sizeGreaterOrEqualTo)
    {
      List<string> result = new List<string>();
      foreach (FileInfo fileInfo in directoryInfo.GetFiles())
      {
        if (fileInfo.Length >= sizeGreaterOrEqualTo)
        {
          result.Add(fileInfo.FullName);
        }
      }

      return result;
    }
  }
}
