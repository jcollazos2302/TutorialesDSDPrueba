using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace RESTTests
{
    /// <summary>
    /// Descripción resumida de AlumnosTest
    /// </summary>
    [TestClass]
    public class AlumnosTest
    {

        [TestMethod]
        public void CRUDTest()
        {

            //Prueba de creacion de alumno via HTTP POST
            string posdata = "{\"Codigo\":\"1\",\"Nombre\":\"Juan\"}";  //JSON
            byte[] data = Encoding.UTF8.GetBytes(posdata);

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(
                "http://localhost:29226/Alumnos.svc/Alumnos");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";

            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            //var res = (HttpWebResponse)req.GetResponse();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string alumnoJSON = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();

            Alumno alumnoCreado = js.Deserialize<Alumno>(alumnoJSON);
            Assert.AreEqual("1", alumnoCreado.Codigo);
            Assert.AreEqual("Juan", alumnoCreado.Nombre);

            //Prueba de obtencion del alumno via HTTP GET
            HttpWebRequest req2 = (HttpWebRequest)WebRequest
                .Create("http://localhost:29226/Alumnos.svc/Alumnos/u20120001");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string alumnoJSON2 = reader2.ReadToEnd();

            JavaScriptSerializer js2 = new JavaScriptSerializer();

            Alumno alumnoObtenido = js2.Deserialize<Alumno>(alumnoJSON2);
            Assert.AreEqual("1", alumnoObtenido.Codigo);
            Assert.AreEqual("Juan", alumnoObtenido.Nombre);

        }
    }
}
