
public class Functions : MonoBehaviour {

	public void DoStuff(){
		print("I'm doing stuff...");

	}
	void Start(){
		DoStuff();
		int result = AddNumbers(5,11);
		print(result);
	}

	public int AddNumbers(int num1,int numb2){
	
		int result = num1 + numb2;

		return result; 
	}	

	
	
}
