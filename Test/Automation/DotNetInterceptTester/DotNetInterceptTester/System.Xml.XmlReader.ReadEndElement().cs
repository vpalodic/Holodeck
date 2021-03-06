namespace DotNetInterceptTester.My_System.Xml.XmlReader
{
public class ReadEndElement_System_Xml_XmlReader
{
public static bool _ReadEndElement_System_Xml_XmlReader( )
{
   //Parameters


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlReader.ReadEndElement();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlReader.ReadEndElement();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
