package teste.senai;

import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteCursosSenai {

	private WebDriver driver; 
	
	@Before
	public void ConfigurarTeste() {
	System.setProperty("webdriver.chrome.driver", "C:\\webdrivers\\chromedriver\\chromedriver.exe");
	driver = new ChromeDriver();
	driver.manage().window().maximize();
	}
	
	@Test
	public void TesteNavegabilidade () {
		driver.get("https://informatica.sp.senai.br/");
		
		//Selecionar campo de busca
		driver.findElement(By.id("Busca1_txtFiltro")).sendKeys("Excel");
		//driver.findElement(By.id("Busca1_txtFiltro")).sendKeys(Keys.ENTER);
		
		//Clicar no botão de busca
		driver.findElement(By.id("Busca1_btnBusca")).click();
		
		
		
	}
	
}
