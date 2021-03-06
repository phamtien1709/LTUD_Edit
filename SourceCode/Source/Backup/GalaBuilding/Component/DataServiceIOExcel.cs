using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;


namespace GalaBuilding.Component
{
    partial class DataServiceIOExcel
    {
        public DataServiceIOExcel()
        {

        }

        private OdbcConnection m_Connection;

        public OdbcConnection Connection
        {
            get { return m_Connection; }
            set { m_Connection = value; }
        }

        private OdbcDataAdapter m_DataAdapter;

        public OdbcDataAdapter DataAdapter
        {
            get { return m_DataAdapter; }
            set { m_DataAdapter = value; }
        }

        private OdbcCommand m_Command;

        public OdbcCommand Command
        {
            get { return m_Command; }
            set { m_Command = value; }
        }

        public void Connect(string path)
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                try
                {
                    m_Connection = new OdbcConnection("Driver={Microsoft Excel Driver (*.xls)}; DBQ=" + path);
                    m_Connection.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kết nối cơ sở dữ liệu không thành công.", "Thông báo");
                }
            }
        }

        public DataTable Load(OdbcCommand command, string path)
        {
            this.Connect(path);

            m_Command = command;
            m_Command.Connection = m_Connection;

            m_DataAdapter = new OdbcDataAdapter(m_Command);


            DataSet dataSet = new DataSet();

            m_DataAdapter.Fill(dataSet, "[Sheet1$]");

            DataTable dtb = dataSet.Tables["[Sheet1$]"];
            m_Connection.Close();
            return dtb;


        }
    }
}
