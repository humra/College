package racunarstvo.pppk;

import javax.sql.DataSource;
import com.microsoft.sqlserver.jdbc.SQLServerDataSource;

class DataSourceCreator {
    public static DataSource createDataSource() {
        SQLServerDataSource ds = new SQLServerDataSource();
        ds.setServerName("localhost");
        ds.setDatabaseName("PPPK5");
        ds.setUser("matija");
        ds.setPassword("sql");
        
        return ds;
    }
}
