package humra.configuration;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Import;

import com.sun.org.apache.xerces.internal.parsers.SecurityConfiguration;

@SpringBootApplication
@ComponentScan({"humra"})
@Import({ SecurityConfiguration.class })
public class Application {

    public static void main(String[] args) {
        SpringApplication.run(Application.class, args);
    }

}
