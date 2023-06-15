/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.cinemasoft.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.cinemasoft.config.DBManager;
import pe.edu.pucp.cinemasoft.dao.ActorDAO;
import pe.edu.pucp.cinemasoft.model.Actor;

/**
 *
 * @author joham
 */
public class ActorMySQL implements ActorDAO {
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public ArrayList<Actor> listarPorNombre(String nombre) {
        ArrayList<Actor> actores = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ACTORES_X_NOMBRE(?)}");
            cs.setString("_nombre", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Actor us = new Actor();
                us.setIdActor(rs.getInt("id_actor"));
                us.setNombre(rs.getString("nombre"));
                us.setApellidoPaterno(rs.getString("apellido_paterno"));
                us.setNacionalidad(rs.getString("nacionalidad"));
                us.setActivo(true);
                actores.add(us);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return actores;
    }
    
}
