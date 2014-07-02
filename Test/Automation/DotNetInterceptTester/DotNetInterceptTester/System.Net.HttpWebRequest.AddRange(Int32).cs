namespace DotNetInterceptTester.My_System.Net.HttpWebRequest
{
public class AddRange_System_Net_HttpWebRequest_System_Int32
{
public static bool _AddRange_System_Net_HttpWebRequest_System_Int32( )
{
   //Parameters
   System.Int32 range = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Net.HttpWebRequest.AddRange(range);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Net.HttpWebRequest.AddRange(range);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}