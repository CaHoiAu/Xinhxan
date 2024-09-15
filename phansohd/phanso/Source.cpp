#include <iostream>
#include <vector>
#include <string>
using namespace std;
class phanso {
private:
    int tu, mau;
public:
    void nhap();
    void xuat();
    void cong(phanso);
    void tru(phanso);
    void nhan(phanso);
    void chia(phanso);
};
void phanso::nhap() {
    cout << "Nhap phan so: " << endl;
    cin >> tu >> mau;
}
void phanso::xuat() {
    cout << tu << "/" << mau << endl;
}
void phanso::cong(phanso a) {
    tu = tu * a.mau + mau * a.tu;
    mau = mau * a.mau;
}
void phanso::tru(phanso a) {
    tu = tu * a.mau - mau * a.tu;
    mau = mau * a.mau;
}
void phanso::nhan(phanso a) {
    tu = tu * a.tu;
    mau = mau * a.mau;
}
void phanso::chia(phanso a) {
    tu = tu * a.mau;
    mau = mau * a.tu;
}
int main(int argc, const char* argv[]) {
    string command = argv[1];
    if (command.compare("sum") == 0) {
        phanso kq;
        for (int i = 2; i < argc; i += 2) {
            int tu = stoi(argv[i]);
            int mau = stoi(argv[i + 1]);
            phanso temp;
            temp.nhap();
            kq.cong(temp);
        }
        cout << "Tong cac phan so: ";
        kq.xuat();
    }
    return 0;
}
