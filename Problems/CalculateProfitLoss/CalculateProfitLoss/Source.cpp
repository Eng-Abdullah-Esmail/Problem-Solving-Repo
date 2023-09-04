#include<iostream>
#include<string>
using namespace std;


void Msg(string mes) {
	cout << mes << endl;
}

class Product {

	string	ProductName;
	float BuyPrice;
	float SalePrice;

public:
	Product() {
	}

	Product ReadInfo() {

		Product _Product;
		Msg("Enter the name of product, please");
		cin >> _Product.ProductName;

		Msg("Enter the price of purchase, please");
		cin >> _Product.BuyPrice;

		Msg("Enter the price of sale, please");
		cin >> _Product.SalePrice;

		return _Product;
	}

	void SetInfo(Product Pro) {
		ProductName = Pro.ProductName;
		BuyPrice = Pro.BuyPrice;
		SalePrice = Pro.SalePrice;
	}


	float getProfit() {
		float Profit = SalePrice - BuyPrice;
		return (float)Profit;
	}

	float getLoss() {
		float Loss = BuyPrice - SalePrice;
	}


	float ProfitPercent(float profit) {

		float percent = (profit / BuyPrice) * 0.100;

		return (float)percent;
	}


	float LossPercent(float loss) {

		float percent = (loss / BuyPrice) * 0.100;

		return (float)percent;
	}

};




void Msg(float mes) {
	cout << mes << endl;
}

int main() {

	Product Item;
	Item.SetInfo(Item.ReadInfo());
	cout << "Profit : " << Item.getProfit() << endl;
	cout << "Percent of Profit : " << Item.ProfitPercent(Item.getProfit()) << endl;
	cout << "Loss : " << Item.getLoss() << endl;
	cout << "Percent Of Loss : " << Item.LossPercent(Item.getLoss()) << endl;


	return 0;
}
