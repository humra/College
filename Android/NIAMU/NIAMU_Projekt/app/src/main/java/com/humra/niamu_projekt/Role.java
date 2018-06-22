package com.humra.niamu_projekt;

import com.google.gson.annotations.SerializedName;

public class Role {
    public Role(){}

    public Role(Integer id, String name) {
        this.id = id;
        this.name = name;
    }

    @SerializedName("ID")
    private Integer id;
    @SerializedName("Name")
    private String name;

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
