-- Table: "CARGO"

-- DROP TABLE "CARGO";

CREATE TABLE CARGO
(
  cargo_codig numeric NOT NULL,
  cargo_nombr character varying(100),
  CONSTRAINT CARGO_pkey PRIMARY KEY (cargo_codig)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE CARGO
  OWNER TO postgres;

----------------------------------------------------------------

-- Table: "CARGO_ORGAN"

-- DROP TABLE "CARGO_ORGAN";

CREATE TABLE CARGO_ORGAN
(
  orcar_codig numeric NOT NULL,
  orcar_salar numeric,
  orcar_cargo numeric,
  orcar_organ numeric,
  CONSTRAINT CARGO_ORGAN_pkey PRIMARY KEY (orcar_codig)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE CARGO_ORGAN
  OWNER TO postgres;

-------------------------------------------------------------------

-- Table: "CIUDAD"

-- DROP TABLE "CIUDAD";

CREATE TABLE CIUDAD
(
  id_ciudad numeric(3,0) NOT NULL,
  nombre character varying(80) NOT NULL,
  fkey_estado numeric NOT NULL,
  CONSTRAINT ciudad_pkey PRIMARY KEY (id_ciudad)
  --,CONSTRAINT ciudad_fkey_estado_fkey FOREIGN KEY (fkey_estado)
    --  REFERENCES ESTADO (id_estado) MATCH SIMPLE
      --ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE CIUDAD
  OWNER TO postgres;

--------------------------------------------------------------

-- Table: "EMPLEADO"

-- DROP TABLE "EMPLEADO";

CREATE TABLE EMPLEADO
(
  emple_codig numeric NOT NULL,
  emple_cedul numeric, -- unique
  --falta nacionalidad
  emple_pnomb character varying(20),
  emple_snomb character varying(20),
  emple_papel character varying(20),
  emple_sapel character varying(20),
  emple_sexo character varying(10),
  emple_ecivi character varying(10),
  emple_thabi numeric,
  emple_tmovi numeric,
  emple_tofic numeric,
  emple_corre character varying(50),
  emple_fiadp date,
  CONSTRAINT emple_codig PRIMARY KEY (emple_codig)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE EMPLEADO
  OWNER TO postgres;

---------------------------------------------------------------------

-- Table: "ESTADO"

-- DROP TABLE "ESTADO";

CREATE TABLE ESTADO
(
  id_estado numeric(3,0) NOT NULL,
  nombre character varying(80) NOT NULL,
  CONSTRAINT estado_pkey PRIMARY KEY (id_estado)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE ESTADO
  OWNER TO postgres;

--------------------------------------------------------------------

-- Table: "MUNICIPIO"

-- DROP TABLE "MUNICIPIO";

CREATE TABLE MUNICIPIO
(
  id_municipio numeric(3,0) NOT NULL,
  nombre character varying(80) NOT NULL,
  fkey_estado numeric(3,0) NOT NULL,
  CONSTRAINT municipio_pkey PRIMARY KEY (id_municipio)
  --,CONSTRAINT municipio_fkey_estado_fkey FOREIGN KEY (fkey_estado)
     -- REFERENCES "ESTADO" (id_estado) MATCH SIMPLE
      --ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE MUNICIPIO
  OWNER TO postgres;
  
-----------------------------------------------------------------------

-- Table: "ORGANO"

-- DROP TABLE "ORGANO";

CREATE TABLE ORGANO
(
  organ_codig numeric NOT NULL,
  organ_rif character varying(20),
  organ_nombr character(200),
  organ_sigla character(10),
  organ_fcrea date,
  organ_ffund date,
  organ_tipoo character varying(20),
  organ_adscr character varying(30),
  organ_corre character varying(50),
  organ_telf1 numeric,
  organ_telf2 numeric,
  organ_recau character varying(50),
  CONSTRAINT organ_codig PRIMARY KEY (organ_codig)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE ORGANO
  OWNER TO postgres;

----------------------------------------------------------------------------

-- Table: "ORGANO_EMPLEADO"

-- DROP TABLE "ORGANO_EMPLEADO";

CREATE TABLE ORGANO_EMPLEADO
(
  oremp_organ numeric,
  oremp_cargo numeric,
  oremp_emple numeric,
  oremp_fingr date,
  oremp_fegre date,
  oremp_tcont character varying(20),
  oremp_orcar numeric
  --,CONSTRAINT "ORGANO_EMPLEADO_oremp_cargo_fkey" FOREIGN KEY (oremp_cargo)
  --    REFERENCES "CARGO" (cargo_codig) MATCH SIMPLE
  --    ON UPDATE NO ACTION ON DELETE NO ACTION,
  --CONSTRAINT "ORGANO_EMPLEADO_oremp_emple_fkey" FOREIGN KEY (oremp_emple)
  --    REFERENCES "EMPLEADO" (emple_codig) MATCH SIMPLE
  --    ON UPDATE NO ACTION ON DELETE NO ACTION,
  --CONSTRAINT "ORGANO_EMPLEADO_oremp_orcar_fkey" FOREIGN KEY (oremp_orcar)
  --    REFERENCES "CARGO_ORGAN" (orcar_codig) MATCH SIMPLE
  --    ON UPDATE NO ACTION ON DELETE NO ACTION,
  --CONSTRAINT "ORGANO_EMPLEADO_oremp_organ_fkey" FOREIGN KEY (oremp_organ)
  --    REFERENCES "ORGANO" (organ_codig) MATCH SIMPLE
  --    ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE ORGANO_EMPLEADO
  OWNER TO postgres;

-----------------------------------------------------------------------------

-- Table: "ORGAN_PERIO"

-- DROP TABLE "ORGAN_PERIO";

CREATE TABLE ORGAN_PERIO
(
  orper_fiact date,
  orper_organ numeric,
  orper_perio numeric
  --,CONSTRAINT "ORGAN_PERIO_orper_organ_fkey" FOREIGN KEY (orper_organ)
  --    REFERENCES "ORGANO" (organ_codig) MATCH SIMPLE
  --    ON UPDATE NO ACTION ON DELETE NO ACTION,
  --CONSTRAINT "ORGAN_PERIO_orper_perio_fkey" FOREIGN KEY (orper_perio)
  --    REFERENCES "PERIODO" (perio_codig) MATCH SIMPLE
  --    ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE ORGAN_PERIO
  OWNER TO postgres;

--------------------------------------------------------------------------------

-- Table: "PERIODO"

-- DROP TABLE "PERIODO";

CREATE TABLE PERIODO
(
  perio_codig numeric NOT NULL,
  perio_anini date,
  perio_anfin date,
  CONSTRAINT perio_codig PRIMARY KEY (perio_codig)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE PERIODO
  OWNER TO postgres;

----------------------------------------------------------------------------------

-- Table: "UBICACION"

-- DROP TABLE "UBICACION";

CREATE TABLE UBICACION
(
  ubica_organ numeric,
  ubica_munic numeric NOT NULL,
  ubica_ciuda numeric,
  ubica_urban numeric
--  ,CONSTRAINT "UBICACION_ubica_ciuda_fkey" FOREIGN KEY (ubica_ciuda)
--      REFERENCES "CIUDAD" (id_ciudad) MATCH SIMPLE
--      ON UPDATE NO ACTION ON DELETE NO ACTION,
--  CONSTRAINT "UBICACION_ubica_munic_fkey" FOREIGN KEY (ubica_munic)
--      REFERENCES "MUNICIPIO" (id_municipio) MATCH SIMPLE
--      ON UPDATE NO ACTION ON DELETE NO ACTION,
--  CONSTRAINT "UBICACION_ubica_organ_fkey" FOREIGN KEY (ubica_organ)
--      REFERENCES "ORGANO" (organ_codig) MATCH SIMPLE
--      ON UPDATE NO ACTION ON DELETE NO ACTION,
--  CONSTRAINT "UBICACION_ubica_urban_fkey" FOREIGN KEY (ubica_urban)
--      REFERENCES "URBANIZACION" (id_urb) MATCH SIMPLE
--      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE UBICACION
  OWNER TO postgres;

--------------------------------------------------------------------------

-- Table: "UBICACION_EMPLEADO"

-- DROP TABLE "UBICACION_EMPLEADO";

CREATE TABLE UBICACION_EMPLEADO
(
  ubemp_emple numeric,
  ubemp_munic numeric NOT NULL,
  ubemp_ciuda numeric,
  ubemp_urban numeric
--  ,CONSTRAINT "UBICACION_ubemp_ciuda_fkey" FOREIGN KEY (ubemp_ciuda)
--      REFERENCES "CIUDAD" (id_ciudad) MATCH SIMPLE
--      ON UPDATE NO ACTION ON DELETE NO ACTION,
--  CONSTRAINT "UBICACION_ubemp_emple_fkey" FOREIGN KEY (ubemp_emple)
--      REFERENCES "EMPLEADO" (emple_codig) MATCH SIMPLE
--      ON UPDATE NO ACTION ON DELETE NO ACTION,
--  CONSTRAINT "UBICACION_ubemp_munic_fkey" FOREIGN KEY (ubemp_munic)
--      REFERENCES "MUNICIPIO" (id_municipio) MATCH SIMPLE
--      ON UPDATE NO ACTION ON DELETE NO ACTION,
--  CONSTRAINT "UBICACION_ubemp_urban_fkey" FOREIGN KEY (ubemp_urban)
--      REFERENCES "URBANIZACION" (id_urb) MATCH SIMPLE
--      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE UBICACION_EMPLEADO
  OWNER TO postgres;

----------------------------------------------------------------------------

-- Table: "URBANIZACION"

-- DROP TABLE "URBANIZACION";

CREATE TABLE URBANIZACION
(
  id_urb numeric(3,0) NOT NULL,
  nombre character varying(80) NOT NULL,
  cod_postal character varying(5) NOT NULL,
  CONSTRAINT urbanizacion_pkey PRIMARY KEY (id_urb)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE URBANIZACION
  OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_cargo_organ_insert(codigo 	CARGO_ORGAN.orcar_codig%type,
                                    						salario CARGO_ORGAN.orcar_salar%type,
                                    						cargo	CARGO_ORGAN.orcar_cargo%type,
                                    						organis	CARGO_ORGAN.orcar_organ%type)
  RETURNS integer AS
$BODY$begin

INSERT INTO CARGO_ORGAN VALUES (codigo, salario, cargo, organis);

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_cargo_organ_insert(CARGO_ORGAN.orcar_codig%type, 
                                    cargo_organ.orcar_salar%type, 
                                    cargo_organ.orcar_cargo%type, 
                                    cargo_organ.orcar_organ%type) OWNER TO postgres;

----------------------------------------------------------------------------
create view view_cargo_select as
  select *
   from cargo;

CREATE OR REPLACE FUNCTION f_cargo_organ_select(codigo 	CARGO_ORGAN.orcar_codig%type,
                                    						cargo	CARGO_ORGAN.orcar_cargo%type,
                                    						organis	CARGO_ORGAN.orcar_organ%type)
  RETURNS char AS
$BODY$
Declare
vl_rec record;

C_cargo cursor (CARGO_ORGAN.orcar_codig%type,
		CARGO_ORGAN.orcar_cargo%type,
		CARGO_ORGAN.orcar_organ%type),
 select * from CARGO_ORGAN 
    where orcar_codig = codigo
    and orcar_organ = organis
    and orcar_cargo = cargo;
    
begin

OPEN C_cargo;
      FETCH C_cargo
        INTO vl_rec;
      CLOSE C_cargo;
      
return(vl_rec);

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_cargo_organ_select(CARGO_ORGAN.orcar_codig%type, 
                                    cargo_organ.orcar_cargo%type, 
                                    cargo_organ.orcar_organ%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_cargo_organ_delete(cargo	CARGO_ORGAN.orcar_cargo%type,
						organis	CARGO_ORGAN.orcar_organ%type)
  RETURNS integer AS
$BODY$
begin

delete from cargo_organ
	where orcar_cargo = cargo
	and orcar_organ = organis;
      
return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_cargo_organ_delete(cargo_organ.orcar_cargo%type, cargo_organ.orcar_organ%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_cargo_organ_update(cargo	CARGO_ORGAN.orcar_cargo%type,
						organis	CARGO_ORGAN.orcar_organ%type)
  RETURNS char AS
$BODY$
begin

update cargo_organ 
	set orcar_cargo = cargo --datos que se van a cambiar
	where orcar_cargo = cargo
	and orcar_organ = organis;
      
return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_cargo_organ_update(cargo_organ.orcar_cargo%type, cargo_organ.orcar_organ%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_cargo_insert(codigo 	cargo.cargo_codig%type,
						nombre_carg cargo.cargo_nombr%type)
  RETURNS integer AS
$BODY$begin

INSERT INTO cargo VALUES (codigo, nombre_carg);

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_cargo_insert(cargo.cargo_codig%type, cargo.cargo_nombr%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_cargo_select(codigo 	cargo.cargo_codig%type,
						nombre_carg cargo.cargo_nombr%type)
  RETURNS char AS
$BODY$
declare
vl_retorno char(200);
begin

select cargo_nombr 
	into vl_retorno
		from cargo 
			where cargo_codig = codigo
			and cargo_nombr = nombre_carg;

return(vl_retorno);

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_cargo_select(cargo.cargo_codig%type, cargo.cargo_nombr%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_cargo_update(codigo 	cargo.cargo_codig%type,
						nombre_carg cargo.cargo_nombr%type)
  RETURNS integer AS
$BODY$
begin

update cargo
	set cargo_nombr = nombre_carg
	where cargo_codig = codigo
	and cargo_nombr = nombre_carg;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_cargo_update(cargo.cargo_codig%type, cargo.cargo_nombr%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_cargo_delete(codigo 	cargo.cargo_codig%type,
						nombre_carg cargo.cargo_nombr%type)
  RETURNS integer AS
$BODY$
begin

delete from cargo
	where cargo_nombr = nombre_carg;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_cargo_delete(cargo.cargo_codig%type, cargo.cargo_nombr%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_ciudad_delete(codigo 	CIUDAD.id_ciudad%type,
						nombrec CIUDAD.nombre%type,
						estado CIUDAD.fkey_estado%type)
  RETURNS integer AS
$BODY$
begin

delete from CIUDAD
	where id_ciudad = codigo
	and nombre = nombrec
	and fkey_estado = estado;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_ciudad_delete(CIUDAD.id_ciudad%type, CIUDAD.nombre%type, CIUDAD.fkey_estado%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_ciudad_insert(codigo 	CIUDAD.id_ciudad%type,
						nombrec CIUDAD.nombre%type,
						estado CIUDAD.fkey_estado%type)
  RETURNS integer AS
$BODY$
begin

insert into ciudad values (codigo, nombrec, estado);

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_ciudad_insert(CIUDAD.id_ciudad%type, CIUDAD.nombre%type, CIUDAD.fkey_estado%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_ciudad_update(--codigo 	CIUDAD.id_ciudad%type,
						nombrec CIUDAD.nombre%type,
						estado CIUDAD.fkey_estado%type)
  RETURNS integer AS
$BODY$
begin

update ciudad 
	set nombre = nombrec
		where nombre = nombrec
		and fkey_estado = estado;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_ciudad_update(CIUDAD.nombre%type, CIUDAD.fkey_estado%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_ciudad_select(--codigo 	CIUDAD.id_ciudad%type,
						nombrec CIUDAD.nombre%type,
						estado CIUDAD.fkey_estado%type)
  RETURNS integer AS
$BODY$
begin

select nombre 
	from ciudad 
		where nombre = nombrec
		and fkey_estado = estado;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_ciudad_select(CIUDAD.nombre%type, CIUDAD.fkey_estado%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_empleado_insert(codigo empleado.emple_codig%type,
											 cedula empleado.emple_cedul%type,
											 p_nombre empleado.emple_pnomb%type,
											 s_nombre empleado.emple_snomb%type,
											 p_apellido empleado.emple_papel%type,
											 s_apellido empleado.emple_sapel%type,
											 sexo empleado.emple_sexo%type,
											 e_civil empleado.emple_ecivi%type,
											 t_hab empleado.emple_thabi%type,
											 t_movil empleado.emple_tmovi%type,
											 t_oficina empleado.emple_tofic%type,
											 correo empleado.emple_corre%type,
											 fecha empleado.emple_fiadp%type)
                       --,var character varying)
  RETURNS integer AS
$BODY$
begin
--CASE var
--WHEN 'i' THEN
insert into empleado 
	values (codigo, cedula, p_nombre, s_nombre, p_apellido, s_apellido, sexo, e_civil, t_hab, t_movil, t_oficina, correo, fecha);
--when 'm' THEN
return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_empleado_insert(empleado.emple_codig%type,	 empleado.emple_cedul%type,
								 empleado.emple_pnomb%type,	 empleado.emple_snomb%type,
								 empleado.emple_papel%type,  empleado.emple_sapel%type,
								 empleado.emple_sexo%type,   empleado.emple_ecivi%type,
								 empleado.emple_thabi%type,  empleado.emple_tmovi%type,
								 empleado.emple_tofic%type,  empleado.emple_corre%type,
								 empleado.emple_fiadp%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_empleado_delete(--codigo empleado.emple_codig%type,
											 cedula empleado.emple_cedul%type)
  RETURNS integer AS
$BODY$
begin

delete from empleado 
	where emple_cedul = cedula;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_empleado_delete(empleado.emple_cedul%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_empleado_update(--codigo empleado.emple_codig%type,
											 cedula empleado.emple_cedul%type,
											 p_nombre empleado.emple_pnomb%type,
											 s_nombre empleado.emple_snomb%type,
											 p_apellido empleado.emple_papel%type,
											 s_apellido empleado.emple_sapel%type,
											 sexo empleado.emple_sexo%type,
											 e_civil empleado.emple_ecivi%type,
											 t_hab empleado.emple_thabi%type,
											 t_movil empleado.emple_tmovi%type,
											 t_oficina empleado.emple_tofic%type,
											 correo empleado.emple_corre%type,
											 fecha empleado.emple_fiadp%type)
  RETURNS integer AS
$BODY$
begin

update empleado 
	set emple_pnomb = p_nombre, emple_snomb = s_nombre, emple_papel = p_apellido, emple_sapel = s_apellido
	  , emple_sexo = sexo, emple_ecivi = e_civil, emple_thabi = t_hab, emple_tmovi = t_movil, emple_tofic = t_oficina
	  , emple_corre = correo, emple_fiadp = fecha
	  	where emple_cedul = cedula;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_empleado_update(	 empleado.emple_cedul%type,
								 empleado.emple_pnomb%type,	 empleado.emple_snomb%type,
								 empleado.emple_papel%type,  empleado.emple_sapel%type,
								 empleado.emple_sexo%type,   empleado.emple_ecivi%type,
								 empleado.emple_thabi%type,  empleado.emple_tmovi%type,
								 empleado.emple_tofic%type,  empleado.emple_corre%type,
								 empleado.emple_fiadp%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_empleado_select(cedula empleado.emple_cedul%type)
  RETURNS varchar AS
$BODY$
declare

vl_retorno varchar(2000);

c_empleado cursor (empleado.emple_cedul%type)

select * from empleado 
		where emple_cedul = cedula;

begin

open c_empleado (cedula)
FETCH c_empleado
	into vl_retorno;
	CLOSE c_empleado;
	

return(vl_retorno);

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_empleado_select(empleado.emple_cedul%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_estado_select(codigo estado.id_estado%type)
  RETURNS varchar AS
$BODY$
begin

select nombre 
	into vl_retorno 
		from estado 
			where id_estado = codigo;

return(vl_retorno);

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_estado_select(estado.id_estado%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_estado_insert(codigo estado.id_estado%type,
										   estado estado.nombre%type)
  RETURNS integer AS
$BODY$
begin

insert into estado 
	values (codigo, estado);

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_estado_insert(estado.id_estado%type, estado.nombre%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_estado_delete(codigo estado.id_estado%type,
										   estado estado.nombre%type)
  RETURNS integer AS
$BODY$
begin

delete from estado where id_estado= codigo and nombre = estado;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_estado_delete(estado.id_estado%type, estado.nombre%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_estado_update(codigo estado.id_estado%type,
										   estado estado.nombre%type)
  RETURNS integer AS
$BODY$
begin

update estado 
	set nombre = estado 
		where id_estado = codigo;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_estado_update(estado.id_estado%type, estado.nombre%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_municipio_insert(codigo municipio.id_municipio%type,
										   	  municipio municipio.nombre%type,
										   	  estado municipio.fkey_estado%type)
  RETURNS integer AS
$BODY$
begin

insert into municipio values (codigo, municipio, estado);

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_municipio_insert(municipio.id_municipio%type, municipio.nombre%type, municipio.fkey_estado%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_municipio_delete(codigo municipio.id_municipio%type,
										   	  municipio municipio.nombre%type,
										   	  estado municipio.fkey_estado%type)
  RETURNS integer AS
$BODY$
begin

delete from municipio 
	where id_municipio = codigo
	and nombre = municipio
	and fkey_estado = estado;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_municipio_delete(municipio.id_municipio%type, municipio.nombre%type, municipio.fkey_estado%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_municipio_update(codigo municipio.id_municipio%type,
										   	  municipio municipio.nombre%type,
										   	  estado municipio.fkey_estado%type)
  RETURNS integer AS
$BODY$
begin

update municipio
	set nombre = municipio
	where id_municipio = codigo
	and nombre = municipio
	and fkey_estado = estado;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_municipio_update(municipio.id_municipio%type, municipio.nombre%type, municipio.fkey_estado%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_municipio_select(--codigo municipio.id_municipio%type,
										   	  --municipio municipio.nombre%type,
										   	  estado municipio.fkey_estado%type)
  RETURNS char AS
$BODY$
begin

select nombre 
	into vl_retorno
	from municipio 
		where fkey_estado = estado

return(vl_retorno);

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_municipio_select(municipio.id_municipio%type
	--, municipio.nombre%type, municipio.fkey_estado%type
	) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_organo_insert(codigo organo.organ_codig%type,
										   rif organo.organ_rif%type,
										   nombre organo.organ_nombr%type,
										   siglas organo.organ_sigla%type,
										   creacion organo.organ_fcrea%type,
										   fund organo.organ_ffund%type,
										   t_organo organo.organ_tipoo%type,
										   adscrito organo.organ_adscr%type,
										   correo organo.organ_corre%type,
										   t_uno organo.organ_telf1%type,
										   t_dos organo.organ_telf2%type,
										   recaudo organo.organ_recau%type)
  RETURNS integer AS
$BODY$
begin

insert into organo
	values(codigo, rif, nombre, siglas, creacion, fund, t_organo, adscrito, correo, t_uno, t_dos, recaudo);

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_organo_insert(	organo.organ_codig%type,	organo.organ_rif%type,
								organo.organ_nombr%type, 	organo.organ_sigla%type,
								organo.organ_fcrea%type,	organo.organ_ffund%type,
								organo.organ_tipoo%type,	organo.organ_adscr%type,
								organo.organ_corre%type,	organo.organ_telf1%type,
								organo.organ_telf2%type,	organo.organ_recau%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_organo_update(--codigo organo.organ_codig%type,
										   rif organo.organ_rif%type,
										   nombre organo.organ_nombr%type,
										   siglas organo.organ_sigla%type,
										   creacion organo.organ_fcrea%type,
										   fund organo.organ_ffund%type,
										   t_organo organo.organ_tipoo%type,
										   adscrito organo.organ_adscr%type,
										   correo organo.organ_corre%type,
										   t_uno organo.organ_telf1%type,
										   t_dos organo.organ_telf2%type,
										   --Le falta la direccion del organo o ente!
										   recaudo organo.organ_recau%type)
  RETURNS integer AS
$BODY$
begin

update organo ,
	set organ_nombr = nombre, organ_siglas = siglas, organ_fcrea = creacion,
		organ_ffund = fund,	organ_tipoo = t_organo, organ_adscr = adscrito,
		organ_corre = correo, organ_telf1 = t_uno, organ_telf2 = t_dos,
		organ_recau = recaudo
		 where organ_rif = rif;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_organo_update(		organo.organ_rif%type,
								organo.organ_nombr%type, 	organo.organ_sigla%type,
								organo.organ_fcrea%type,	organo.organ_ffund%type,
								organo.organ_tipoo%type,	organo.organ_adscr%type,
								organo.organ_corre%type,	organo.organ_telf1%type,
								organo.organ_telf2%type,	organo.organ_recau%type) OWNER TO postgres;

----------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION f_organo_delete(--codigo organo.organ_codig%type,
										   rif organo.organ_rif%type)
  RETURNS integer AS
$BODY$
begin
select organ_adscr into vl_retorno FROM ORGANO where organ_rif = RIF;

if vl_retorno = true then
vl_retorno := "posee organos adscrito y no puede ser eliminado";
else
delete from organo
		 where organ_rif = rif;
end if;
return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_organo_delete(	organo.organ_rif%type) OWNER TO postgres;

CREATE OR REPLACE FUNCTION f_organo_select(--codigo organo.organ_codig%type,
										   rif organo.organ_rif%type,
										   nombre organo.organ_nombr%type,
										   siglas organo.organ_sigla%type,
										   creacion organo.organ_fcrea%type,
										   fund organo.organ_ffund%type,
										   t_organo organo.organ_tipoo%type,
										   adscrito organo.organ_adscr%type,
										   correo organo.organ_corre%type,
										   t_uno organo.organ_telf1%type,
										   t_dos organo.organ_telf2%type,
										   --Le falta la direccion del organo o ente!
										   recaudo organo.organ_recau%type)
  RETURNS integer AS
$BODY$
begin

update organo 
	set organ_nombr = nombre, organ_siglas = siglas, organ_fcrea = creacion,
		organ_ffund = fund,	organ_tipoo = t_organo, organ_adscr = adscrito,
		organ_corre = correo, organ_telf1 = t_uno, organ_telf2 = t_dos,
		organ_recau = recaudo
		 where organ_rif = rif;

return 0;

end;$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION f_organo_select(		organo.organ_rif%type,
								organo.organ_nombr%type, 	organo.organ_sigla%type,
								organo.organ_fcrea%type,	organo.organ_ffund%type,
								organo.organ_tipoo%type,	organo.organ_adscr%type,
								organo.organ_corre%type,	organo.organ_telf1%type,
								organo.organ_telf2%type,	organo.organ_recau%type) OWNER TO postgres;