package com.humra.niamu_projekt;

import java.util.List;
import com.humra.niamu_projekt.Champion;
import com.humra.niamu_projekt.Role;
import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.DELETE;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface ApiInterface {
    @GET("api/Champions")
    Call<List<Champion>> getChampions();
    @GET("api/Roles")
    Call<List<Role>> getRoles();
    @POST("api/Champions")
    Call<Champion> createChamp(@Body Champion champ);
    @PUT("api/Champions/{id}")
    Call<Champion> updateChamp(@Path("id") String champId, @Body Champion champ);
    @DELETE("api/Champions/{id}")
    Call<Champion> deleteChamp(@Path("id") String champId);
}
