#include<iostream>
using namespace std;
class animal
{
	public:
		virtual void sound()
		{
			cout<<"animal sound"<<endl;
		}
};
class dog:public animal
{
	public:
		void sound()
		{
			cout<<"dog sound is woof-woof"<<endl;
		}
};
class cat:public animal
{
	public:
		void sound()
		{
			cout<<"cat sound is meow-meow"<<endl;
		}
};
class cow:public animal
{
	public:
		void sound()
		{
			cout<<"cow sound is maa-maa"<<endl;
		}
};
int main()
{
	animal *a;
	animal a1;
	dog d;
	cat c;
	cow c1;
	a=&a1;
	a->sound();
	a=&d;
	a->sound();
	a=&c;
	a->sound();
	a=&c1;
	a->sound();
	return 0;
}
