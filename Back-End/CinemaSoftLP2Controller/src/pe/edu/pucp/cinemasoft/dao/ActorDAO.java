/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package pe.edu.pucp.cinemasoft.dao;

import java.util.ArrayList;
import pe.edu.pucp.cinemasoft.model.Actor;

/**
 *
 * @author joham
 */
public interface ActorDAO {
    public ArrayList<Actor> listarPorNombre(String nombre);
}
