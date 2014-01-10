using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuidditchWPF
{
    [Serializable]
    public class PreferenceUtilisateur
    {
        private string _login;
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        private double _widthWindow;
        public double WidthWindow
        {
            get { return _widthWindow; }
            set { _widthWindow = value; }
        }

        private double _heightWindow;
        public double HeightWindow
        {
            get { return _heightWindow; }
            set { _heightWindow = value; }
        }

        private double _topWindow;
        public double TopWindow
        {
            get { return _topWindow; }
            set { _topWindow = value; }
        }

        private double _leftWindow;
        public double LeftWindow
        {
            get { return _leftWindow; }
            set { _leftWindow = value; }
        }

        public void Save()
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(_login + ".xml");
                XmlSerializer serializer = new XmlSerializer(typeof(PreferenceUtilisateur));
                serializer.Serialize(sw, this);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }

        public void Load()
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader(_login + ".xml");
                XmlSerializer serializer = new XmlSerializer(typeof(PreferenceUtilisateur));
                PreferenceUtilisateur pref = (PreferenceUtilisateur)serializer.Deserialize(sr);
                this.HeightWindow = pref.HeightWindow;
                this.WidthWindow = pref.WidthWindow;
                this.TopWindow = pref.TopWindow;
                this.LeftWindow = pref.LeftWindow;
            }
            catch (Exception)
            {
                this.TopWindow = 0;
                this.LeftWindow = 0;
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }
    }
}
