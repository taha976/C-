#include <iostream>
#include <string>
#include <vector> // vector kullanarak paketleri tutacağız.
#include <algorithm> // list içinde find yaparken kullaılır.
#include <fstream> // Dosya işlemleri için
using namespace std;

class Paket{
    private:
    string sourceIP;
    string destinationIP;
    int paketBoyutu;
    public:
    Paket(string sIP, string dIP, int pByt){
        sourceIP = sIP;
        destinationIP = dIP;
        paketBoyutu = pByt;
    }
    void Paket_Alma(){
        cout<<"Kaynak ıp giriniz: ";
        cin>>sourceIP;
        cout<<"Hedef ıp giriniz: ";
        cin>>destinationIP;
        cout<<"Paket boyutu giriniz: ";
        cin>>paketBoyutu;
        
    }
    bool Paket_Kontrol(vector<Paket>& paketListesi){
        for(const auto& paket : paketListesi){
            if(paket.sourceIP == sourceIP && paket.destinationIP == destinationIP && paket.paketBoyutu == paketBoyutu){
                cout<<"Bu paket zaten listede var."<<endl;
                return true; // Paket zaten listede var.
            }
        }
        cout<<"Bu paket listede yok."<<endl;
        return false; // Paket listede yok.
    }
    void Dosya_Yazma(){
        ofstream dosya("paket_logları.txt", ios::app); // Dosyayı ekleme modunda açıyoruz, böylece eski veriler silinmez.
        if(dosya.is_open()){
            dosya <<"Source IP: " << sourceIP << ", Destination IP: " <<destinationIP << ", Paket Boyutu: " << paketBoyutu << endl;
            dosya.close();
        }
    }

};
int main() {
    vector<Paket> paketListesi;
    Paket p1("", "", 0);
    char secim;
    
    while(true) { // Döngü burada başlar
        p1.Paket_Alma(); // 1. Veriyi al
        
        // 2. Kontrol et (Listeyi gönderiyoruz)
        bool kontrol = p1.Paket_Kontrol(paketListesi); 

        if(kontrol) {
            // Zaten varsa eklemiyoruz
            cout << "Erisim Reddedildi: Paket zaten mevcut." << endl;
        } 
        else {
            // Yoksa listeye ekle
            paketListesi.push_back(p1);
            cout << "Erisim Onaylandi: Paket listeye islendi." << endl;
            p1.Dosya_Yazma();
            cout<<" Paket logları dosyaya yazıldı."<<endl;
        }

        // 3. Kullanıcıya sor: Devam mı tamam mı?
        cout << "Baska paket girmek ister misiniz? (e/h): ";
        cin >> secim;
        if(secim == 'h' || secim == 'H') {
            int boyut = paketListesi.size();
            cout<< " Toplam paket sayisi: "<< boyut <<endl;
            break; // Doğru işlemin altında olmalıdır, böylece döngü burada biter.
        }
        
    } // while döngüsü burada bitmeli!

    return 0;
} 