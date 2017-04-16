using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnmanagedCode.HW.PowerManagementApi.Task2COM;

namespace UnmanagedCode.HW.PowerManagementApi.Task3.Tests
{
    [TestClass]
    public class HibernateFileManagerTests
    {
        private PowerManagerCustom _powerManagerCustom;

        [TestInitialize]
        public void Init()
        {
            _powerManagerCustom = new PowerManagerCustom();
        }
        [TestMethod]
        public void ReserveFile()
        {
            _powerManagerCustom.ReserveFile();
            Assert.IsTrue(IsHiberfilFileExists());
        }

        [TestMethod]
        public void DeleteFile()
        {
            _powerManagerCustom.DeleteFile();
            Assert.IsFalse(IsHiberfilFileExists());
        }

        private bool IsHiberfilFileExists()
        {
            return File.Exists($"c:\\hiberfil.sys");
        }
    }
}
