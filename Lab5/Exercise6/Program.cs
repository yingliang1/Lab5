using System;

Sqlconnection conn = new Sqlconnection(MyConnectString);
Sqlcommand cmd = new sqlcommand(“sp_Myproc”, conn);
conn.open();
cmd.ExecuteNonQuery();
And
Sqlconnection conn=new sqlconnection(Myconnectstring);
Sqlcommand cmd = new sqlcommand(“sp_Myproc”, conn);
Using(conn)
{
    Conn.open();
    cmd.ExecuteNonQuery();
}

