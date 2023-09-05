#include <iostream>
using namespace std;
class animal
{
	public:
		void eat()
		{
			cout<<"eating"<<endl;
		}
};
class dog: public animal
{
	public:
		void bark()
		{
			cout<<"dog bark";
		}
};
int main()
{
	dog d1;
	d1.eat();
	d1.bark();
	return 0;
}
