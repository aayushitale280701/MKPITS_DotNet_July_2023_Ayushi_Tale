#include<iostream>
using namespace std;
class employee
{
	public:
		string employee_name;
		string designation;
		int salary;
		void getdata()
		{
			cout<<"enter employee_name,salary,designation";
			cin>>employee_name>>salary>>designation;
		}
		void displaydata()
		{
			cout<<"name"<<"name"<<endl;
			cout<<"salary"<<"salary"<<endl;
			cout<<"designation"<<"designation"<<endl;
			
		}
};
int main()
{
	employee emp1,emp2;
	cout<<"employee1"<<endl;
	emp1.getdata();
	emp1.displaydata();
	cout<<"employee2"<<endl;
	emp2.getdata();
	emp2.displaydata();
	return 0;
}
