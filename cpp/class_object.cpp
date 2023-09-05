#include <iostream>
using namespace std;
class car
{
	public:
		string model;
		string made_in;
		int year;
	void startengine()
	{
		cout<<"engine started"<<endl;		
	}
	void brake()
	{
		cout<<"brake applied";
	}
};
int main()
{
	car c1;
	c1.made_in="march";
	c1.model="suv";
	c1.year=2020;
	cout <<"made_in"<<c1.made_in<<endl;
	cout <<"model"<<c1.model<<endl;
	cout <<"model"<<c1.year<<endl;
	c1.startengine();
	c1.brake();
	return 0;
}
