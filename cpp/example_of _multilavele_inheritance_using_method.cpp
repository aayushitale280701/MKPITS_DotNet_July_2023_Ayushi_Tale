#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobile_no;
		void getpersondata(string name, int mobile_no)
		{
			this->name=name;
			this->mobile_no=mobile_no;
		}
};
class Employee:public person
{
	public:
		int emp_no;
		int salary;
		void getemployeedata(int e,int s)
		{
			this->emp_no=e;
			this->salary=s;
		}
		void displydata()
		{
			cout<<"name"<<name<<endl;
			cout<<"mobile_no"<<mobile_no<<endl;
			cout<<"emp_no"<<emp_no<<endl;
			cout<<"salary"<<salary<<endl;
		}
};
int main()
{
	Employee emp;
	cout<<"enter emp details";
	cin>>emp.name>>emp.mobile_no>>emp.emp_no>>emp.salary;
	emp.getpersondata(emp.name,emp.mobile_no);
	emp.getemployeedata(emp.emp_no,emp.salary);
	emp.displydata();
	return 0;
}
