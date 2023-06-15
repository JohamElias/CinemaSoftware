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
import pe.edu.pucp.cinemasoft.dao.PeliculaDAO;
import pe.edu.pucp.cinemasoft.model.Actor;
import pe.edu.pucp.cinemasoft.model.Genero;
import pe.edu.pucp.cinemasoft.model.Pelicula;

/**
 *
 * @author joham
 */
public class PeliculaMySQL implements PeliculaDAO{
    private Connection con;
    private ResultSet rs;
    private CallableStatement cs;
    @Override
    public int insertar(Pelicula pelicula) {
        int resultado=0;
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PELICULA(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_pelicula", 
                    java.sql.Types.INTEGER);
            cs.setInt("_fid_genero", pelicula.getGenero().getIdGenero());
            cs.setString("_titulo", pelicula.getTitulo());
            cs.setDate("_fecha_estreno", new java.sql.Date(pelicula.getFechaEstreno().getTime()) );
            cs.setTime("_duracion", pelicula.getDuracion());
            cs.setBoolean("_disponible_subtitulada", pelicula.isDisponibleSubtitulada());
            cs.setBoolean("_disponible_doblada", pelicula.isDisponibleDoblada());
            cs.setString("_sinopsis", pelicula.getSinopsis());
            cs.setBytes("_portada", pelicula.getPortada());
            cs.executeUpdate();
            pelicula.setIdPelicula(cs.getInt("_id_pelicula"));
            System.out.println("Se inserto un usuario correctamente");
            resultado = pelicula.getIdPelicula();
            for(Actor act:pelicula.getActores()){
                cs = con.prepareCall("{call INSERTAR_PELICULA_ACTOR(?,?,?)}");
                cs.registerOutParameter("_id_pelicula_actor", 
                    java.sql.Types.INTEGER);
                cs.setInt("_fid_pelicula", pelicula.getIdPelicula());
                cs.setInt("_fid_actor", act.getIdActor());
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return resultado;
    }
    @Override
    public ArrayList<Pelicula> listarPorNombre(String nombre) {
        ArrayList<Pelicula> peliculas = new ArrayList<>();
        try{
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PELICULAS_X_TITULO(?)}");
            cs.setString("_titulo", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Pelicula us = new Pelicula();
                us.setIdPelicula(rs.getInt("id_pelicula"));
                us.setTitulo(rs.getString("titulo"));
                us.setGenero(new Genero());
                us.getGenero().setIdGenero(rs.getInt("id_genero"));
                us.setDisponibleDoblada(rs.getBoolean("disponible_doblada"));
                us.setDisponibleSubtitulada(rs.getBoolean("disponible_subtitulada"));
                us.setSinopsis(rs.getString("sinopsis"));
                us.setPortada(rs.getBytes("portada"));
                us.setDuracion(rs.getTime("duracion"));
                us.setFechaEstreno(rs.getDate("fecha_estreno"));
                us.setActivo(true);
                peliculas.add(us);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return peliculas;
    }
}
