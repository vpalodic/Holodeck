namespace DotNetInterceptTester.My_System.Net.Sockets.UdpClient
{
public class Close_System_Net_Sockets_UdpClient
{
public static bool _Close_System_Net_Sockets_UdpClient( )
{
   //Parameters


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Net.Sockets.UdpClient.Close();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Net.Sockets.UdpClient.Close();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
