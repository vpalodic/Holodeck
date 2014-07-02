namespace DotNetInterceptTester.My_System.Xml.XmlProcessingInstruction
{
public class Normalize_System_Xml_XmlProcessingInstruction
{
public static bool _Normalize_System_Xml_XmlProcessingInstruction( )
{
   //Parameters


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlProcessingInstruction.Normalize();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlProcessingInstruction.Normalize();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}