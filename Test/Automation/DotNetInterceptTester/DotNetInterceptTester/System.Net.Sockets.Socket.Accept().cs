namespace DotNetInterceptTester.My_System.Net.Sockets.Socket
{
public class Accept_System_Net_Sockets_Socket
{
public static bool _Accept_System_Net_Sockets_Socket( )
{
   //Parameters

   //ReturnType/Value
   System.Net.Sockets.Socket returnVal_Real = null;
   System.Net.Sockets.Socket returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Net.Sockets.Socket.Accept();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Net.Sockets.Socket.Accept();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
