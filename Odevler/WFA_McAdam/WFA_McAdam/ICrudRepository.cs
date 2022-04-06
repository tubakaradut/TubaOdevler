using System;

namespace WFA_McAdam
{
    public interface ICrudRepository
    {
        //Ekleme
        void Ekle(object obj);

        ////Güncelleme
        //string Update();

        ////Silme
        //string Delete();

        ////Listeleme
        //List<Urun> List();

    }
}
