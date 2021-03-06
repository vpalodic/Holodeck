namespace DotNetInterceptTester.My_System.Diagnostics.Debug
{
public class WriteIf_System_Boolean_System_Object
{
public static bool _WriteIf_System_Boolean_System_Object( )
{
   //Parameters
   System.Boolean condition = null;
   System.Object _value = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Diagnostics.Debug.WriteIf(condition,_value);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Diagnostics.Debug.WriteIf(condition,_value);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
