
//A funtion with a parameter is like a machine which is the function that produces different results dependent on what is put into the machine. The parameter is kind of like the thing that you run through the machine.

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
		int total = Time(12,5);
		print(total);
		float totalSpeed = Speed(0.00f,50.50f);
		print(totalSpeed);
		
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
	public int Time(int startTime, int hoursPast){
		
		int total = startTime + hoursPast;
		return total;
	}
	public float Speed(float startSpeed, float acceleration){
		
		float totalSpeed = startSpeed + acceleration;
		return totalSpeed;
	}
	
	

	


	
	
}
