package com.humra.niamu_projekt;

import com.google.gson.annotations.SerializedName;

public class Champion {
    public Champion(){}
    @SerializedName("Name")
    private String name;
    @SerializedName("ID")
    private Integer id;
    @SerializedName("Url_Image")
    private String imageUrl;
    @SerializedName("Bio")
    private String bio;
    @SerializedName("Role")
    private Integer role;

    public Champion(String name, Integer id, String imageUrl, String bio, Integer role) {
        this.name = name;
        this.id = id;
        this.imageUrl = imageUrl;
        this.bio = bio;
        this.role = role;
    }

    public Champion(String name, String imageUrl, String bio, Integer role) {
        this.name = name;
        this.imageUrl = imageUrl;
        this.bio = bio;
        this.role = role;
    }


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getImageUrl() {
        return imageUrl;
    }

    public void setImageUrl(String imageUrl) {
        this.imageUrl = imageUrl;
    }

    public String getBio() {
        return bio;
    }

    public void setBio(String bio) {
        this.bio = bio;
    }

    public Integer getRole() {
        return role;
    }

    public void setRole(Integer role) {
        this.role = role;
    }


}
