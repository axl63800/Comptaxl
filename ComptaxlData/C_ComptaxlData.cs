using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace ComptaxlData
{
    [Serializable]
    public class C_ComptaxlData
    {
        private const string c_ClientListFileName = "Clients.bin";
        private const string c_PaymentListFileName = "Payments.bin";
        private const string c_PhoneListFileName = "Phones.bin";
        private const string c_UserListFileName = "Users.bin";
        private const string c_RdvListFileName = "Rdvs.bin";
        private const string c_RdvTypeListFileName = "RdvTypes.bin";
        private const string c_PhoneTypeListFileName = "PhoneTypes.bin";

        private List<C_Client> m_ClientList;

        public List<C_Client> ClientList
        {
            get { return m_ClientList; }
            set { m_ClientList = value; }
        }
        private List<C_Payment> m_PaymentList;

        public List<C_Payment> PaymentList
        {
            get { return m_PaymentList; }
            set { m_PaymentList = value; }
        }
        private List<C_Phone> m_PhoneList;

        public List<C_Phone> PhoneList
        {
            get { return m_PhoneList; }
            set { m_PhoneList = value; }
        }
        private List<C_Rdv> m_RdvList;

        public List<C_Rdv> RdvList
        {
            get { return m_RdvList; }
            set { m_RdvList = value; }
        }
        private List<C_TypeRdv> m_TypeRdvList;

        public List<C_TypeRdv> TypeRdvList
        {
            get { return m_TypeRdvList; }
            set { m_TypeRdvList = value; }
        }
        private List<C_User> m_UserList;

        public List<C_User> UserList
        {
            get { return m_UserList; }
            set { m_UserList = value; }
        }
        private List<C_PhoneType> m_PhoneTypeList;

        public List<C_PhoneType> PhoneTypeList
        {
            get { return m_PhoneTypeList; }
            set { m_PhoneTypeList = value; }
        }
        public C_ComptaxlData()
        {
            Deserialize();
        }

        private void CopySvg()
        {
            CopySvg(Application.CommonAppDataPath + "\\" + c_ClientListFileName);
            CopySvg(Application.CommonAppDataPath + "\\" + c_PaymentListFileName);
            CopySvg(Application.CommonAppDataPath + "\\" + c_RdvListFileName);
            CopySvg(Application.CommonAppDataPath + "\\" + c_RdvTypeListFileName);
            CopySvg(Application.CommonAppDataPath + "\\" + c_UserListFileName);
            CopySvg(Application.CommonAppDataPath + "\\" + c_PhoneTypeListFileName);
        }

        private void CopySvg(string FileToSvg)
        {
            if (File.Exists(FileToSvg)) File.Copy(FileToSvg, FileToSvg + "." +  DateTime.Now.ToString("yyyyMMdd") + ".bak", true);
        }

        public void Serialize()
        {
            CopySvg();
            Serialize(Application.CommonAppDataPath + "\\" + c_ClientListFileName, m_ClientList);
            Serialize(Application.CommonAppDataPath + "\\" + c_PaymentListFileName, m_PaymentList);
            Serialize(Application.CommonAppDataPath + "\\" + c_RdvListFileName, m_RdvList);
            Serialize(Application.CommonAppDataPath + "\\" + c_RdvTypeListFileName, m_TypeRdvList);
            Serialize(Application.CommonAppDataPath + "\\" + c_UserListFileName, m_UserList);
            Serialize(Application.CommonAppDataPath + "\\" + c_PhoneTypeListFileName, m_PhoneTypeList);


        }
        public void Deserialize()
        {
            object ObjToDeserialize = null;
            Deserialize(Application.CommonAppDataPath + "\\" + c_ClientListFileName, ref ObjToDeserialize, "List<C_Client>");
            if (ObjToDeserialize != null) m_ClientList = (List<C_Client>)ObjToDeserialize;
            else m_ClientList = new List<C_Client>();

            ObjToDeserialize = null;
            Deserialize(Application.CommonAppDataPath + "\\" + c_PaymentListFileName, ref ObjToDeserialize, "List<C_Payment>");
            if (ObjToDeserialize != null) m_PaymentList = (List<C_Payment>)ObjToDeserialize;
            else m_PaymentList = new List<C_Payment>();
            ObjToDeserialize = null;
            Deserialize(Application.CommonAppDataPath + "\\" + c_RdvListFileName, ref ObjToDeserialize, "List<C_Rdv>");
            if (ObjToDeserialize != null) m_RdvList = (List<C_Rdv>)ObjToDeserialize;
            else m_RdvList = new List<C_Rdv>();
            ObjToDeserialize = null;
            Deserialize(Application.CommonAppDataPath + "\\" + c_RdvTypeListFileName, ref ObjToDeserialize, "List<C_TypeRdv>");
            if (ObjToDeserialize != null) m_TypeRdvList = (List<C_TypeRdv>)ObjToDeserialize;
            else m_TypeRdvList = new List<C_TypeRdv>();
            ObjToDeserialize = null;
            Deserialize(Application.CommonAppDataPath + "\\" + c_UserListFileName, ref ObjToDeserialize, "List<C_User>");
            if (ObjToDeserialize != null) m_UserList = (List<C_User>)ObjToDeserialize;
            else m_UserList = new List<C_User>();

            ObjToDeserialize = null;
            Deserialize(Application.CommonAppDataPath + "\\" + c_PhoneTypeListFileName, ref ObjToDeserialize, "List<C_PhoneType>");
            if (ObjToDeserialize != null) m_PhoneTypeList = (List<C_PhoneType>)ObjToDeserialize;
            else
            {
                m_PhoneTypeList = new List<C_PhoneType>();
                string[] ListPhoneTypeDefault = Enum.GetNames(typeof(e_PhoneType));
                for (int i = 0; i < ListPhoneTypeDefault.Length; i++)
                {
                    m_PhoneTypeList.Add(new C_PhoneType(ListPhoneTypeDefault[i]));
                }
            }
        }

        private void Serialize(string FullFileName, object ObjectToSerialize)
        {
            if (ObjectToSerialize == null) return;
            FileInfo fi = new FileInfo(FullFileName);
            try
            {
                FileIOPermission myperm = new FileIOPermission(FileIOPermissionAccess.AllAccess, fi.Directory.Parent.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + fi.Directory.Parent.FullName + "\r\n" + fi.FullName);
            }
            if (!Directory.Exists(fi.DirectoryName)) Directory.CreateDirectory(fi.DirectoryName);
            FileStream fs = new FileStream(FullFileName, FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, ObjectToSerialize);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

        }

        public void Deserialize(string FullFileName, ref object ObjectToDeserialize, string TypeName)
        {
            if (!File.Exists(FullFileName)) return;
            FileInfo fi = new FileInfo(FullFileName);
            FileStream fs = null;
            try
            {
                FileIOPermission myPerm = new FileIOPermission(FileIOPermissionAccess.AllAccess, fi.DirectoryName);

                fs = new FileStream(FullFileName, FileMode.Open);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
            try
            {
                //Assembly myass = Assembly.LoadFrom(@"C:\C2jV2008\Axis3\Compact\Compact\bin\Release\compact Axis3.exe");
                //ObjectToDeserialize = myass.CreateInstance("Axis3.Lib"+TypeName);

                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and 
                // assign the reference to the local variable.
                ObjectToDeserialize = formatter.Deserialize(fs);


            }

            catch (SerializationException e)
            {
                Trace.WriteLine("Failed to deserialize. Reason: " + e.Message);


            }
            catch (Exception e)
            {
                Trace.Write(e.Message);
            }
            finally
            {

                if (fs != null) fs.Close();
            }
        }
    }
}
