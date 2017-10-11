
public class Functions : MonoBehaviour {

	public void DoStuff(){
		print("I'm doing stuff...");

	}
	void Start(){
		DoStuff();
		int result = AddNumbers(5,11);
		print(result);
		int total = Health(100,50);
		print(total);
		float sum = Money(1065.50f,650.00f);
		print(sum);
		Help();
	}

	public int AddNumbers(int num1,int numb2){
	
		int result = num1 + numb2;

		return result; 
	}	
	public int Health(int maxHealth,int damage){

		int total = maxHealth - damage;
		return total;
	}
	public float Money(float totalCash, float itemCostSword){

		float sum = totalCash - itemCostSword;
		return sum;

	}
	public void Help(){
		print("HELP ME!!");

	}
	

	


	
	
}
