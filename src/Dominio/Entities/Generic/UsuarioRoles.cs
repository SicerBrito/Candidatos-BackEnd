namespace Dominio.Entities.Generic;
    public class UsuarioRoles : BaseEntity {
        
        // Propiedades
        public int UsuarioId { get; set; }
        public Usuario ? Usuarios { get; set; }
        public int RolId { get; set; }
        public Rol ? Roles { get; set; }

    }
