package com.humra.medjuispit02zadatak01;


import org.greenrobot.greendao.annotation.Entity;
import org.greenrobot.greendao.annotation.Id;
import org.greenrobot.greendao.annotation.NotNull;
import org.greenrobot.greendao.annotation.ToOne;
import org.greenrobot.greendao.annotation.Generated;
import org.greenrobot.greendao.DaoException;

@Entity
public class Student {
    @Id
    private Long id;

    @NotNull
    private String ime;

    @NotNull
    private String prezime;

    @NotNull
    private Long mjestoID;

    @ToOne(joinProperty = "mjestoID")
    private Mjesto mjesto;

    @Override
    public String toString() {
        return ime + " " + prezime;
    }

    /** Used to resolve relations */
    @Generated(hash = 2040040024)
    private transient DaoSession daoSession;

    /** Used for active entity operations. */
    @Generated(hash = 1943931642)
    private transient StudentDao myDao;

    @Generated(hash = 53092972)
    public Student(Long id, @NotNull String ime, @NotNull String prezime,
            @NotNull Long mjestoID) {
        this.id = id;
        this.ime = ime;
        this.prezime = prezime;
        this.mjestoID = mjestoID;
    }

    @Generated(hash = 1556870573)
    public Student() {
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getIme() {
        return this.ime;
    }

    public void setIme(String ime) {
        this.ime = ime;
    }

    public String getPrezime() {
        return this.prezime;
    }

    public void setPrezime(String prezime) {
        this.prezime = prezime;
    }

    public Long getMjestoID() {
        return this.mjestoID;
    }

    public void setMjestoID(Long mjestoID) {
        this.mjestoID = mjestoID;
    }

    @Generated(hash = 837523481)
    private transient Long mjesto__resolvedKey;

    /** To-one relationship, resolved on first access. */
    @Generated(hash = 1030486401)
    public Mjesto getMjesto() {
        Long __key = this.mjestoID;
        if (mjesto__resolvedKey == null || !mjesto__resolvedKey.equals(__key)) {
            final DaoSession daoSession = this.daoSession;
            if (daoSession == null) {
                throw new DaoException("Entity is detached from DAO context");
            }
            MjestoDao targetDao = daoSession.getMjestoDao();
            Mjesto mjestoNew = targetDao.load(__key);
            synchronized (this) {
                mjesto = mjestoNew;
                mjesto__resolvedKey = __key;
            }
        }
        return mjesto;
    }

    /** called by internal mechanisms, do not call yourself. */
    @Generated(hash = 1544293837)
    public void setMjesto(@NotNull Mjesto mjesto) {
        if (mjesto == null) {
            throw new DaoException(
                    "To-one property 'mjestoID' has not-null constraint; cannot set to-one to null");
        }
        synchronized (this) {
            this.mjesto = mjesto;
            mjestoID = mjesto.getId();
            mjesto__resolvedKey = mjestoID;
        }
    }

    /**
     * Convenient call for {@link org.greenrobot.greendao.AbstractDao#delete(Object)}.
     * Entity must attached to an entity context.
     */
    @Generated(hash = 128553479)
    public void delete() {
        if (myDao == null) {
            throw new DaoException("Entity is detached from DAO context");
        }
        myDao.delete(this);
    }

    /**
     * Convenient call for {@link org.greenrobot.greendao.AbstractDao#refresh(Object)}.
     * Entity must attached to an entity context.
     */
    @Generated(hash = 1942392019)
    public void refresh() {
        if (myDao == null) {
            throw new DaoException("Entity is detached from DAO context");
        }
        myDao.refresh(this);
    }

    /**
     * Convenient call for {@link org.greenrobot.greendao.AbstractDao#update(Object)}.
     * Entity must attached to an entity context.
     */
    @Generated(hash = 713229351)
    public void update() {
        if (myDao == null) {
            throw new DaoException("Entity is detached from DAO context");
        }
        myDao.update(this);
    }

    /** called by internal mechanisms, do not call yourself. */
    @Generated(hash = 1701634981)
    public void __setDaoSession(DaoSession daoSession) {
        this.daoSession = daoSession;
        myDao = daoSession != null ? daoSession.getStudentDao() : null;
    }
}
