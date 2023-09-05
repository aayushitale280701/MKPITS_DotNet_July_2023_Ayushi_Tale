#include<iostream>
using namespace std;
class person
{
	protected:
		string name;
};
class student:public person
{
	public:
		void putdata(string s)
		{
			name=s;
		}
		void displaydata()
		{
			cout<<"name :"<<name;
		}
};
int main()
{
	student s1;
	s1.putdata("Ayushi");
	s1.displaydata();
	return 0;
}
