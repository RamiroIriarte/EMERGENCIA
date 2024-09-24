using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EMERGENCIA
{
    public class Class1
    {
        #region controller persona
        ////CONTROLLER PERSONA
        //private readonly Context context;

        //public ControllerPersona(Context context)
        //{
        //    this.context = context;
        //}


        //[HttpGet]
        //public async Task<ActionResult<List<Persona>>> Get()
        //{
        //    return await context.Personas.ToListAsync();
        //}

        ////-------------
        ////Método Get por ID
        ////-------------

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<Persona>> Get(int id)
        //{
        //    Persona? pepe = await context.Personas
        //        .FirstOrDefaultAsync(x => x.Id == id);

        //    if (pepe == null)
        //    {
        //        return NotFound("No se encontro la persona solicitada");
        //    }

        //    return pepe;
        //}

        //[HttpPost]
        //public async Task<ActionResult<int>> Post(Persona entidad)
        //{
        //    try
        //    {
        //        context.Personas.Add(entidad);
        //        await context.SaveChangesAsync();
        //        return entidad.Id;
        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }
        //}


        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(int id, [FromBody] Persona entidad)
        //{
        //    if (id == entidad.Id)
        //    {
        //        return BadRequest("Datos incorrectos");
        //    }

        //    var modificable = await context.Personas
        //        .Where(reg => reg.Id == id).FirstOrDefaultAsync();

        //    if (modificable == null)
        //    {
        //        return NotFound("No se encontro la persona solicitada");
        //    }

        //    modificable.Nombre = entidad.Nombre;
        //    modificable.Apellido = entidad.Apellido;
        //    modificable.Documento = entidad.Documento;
        //    modificable.TipoDocumentoId = entidad.TipoDocumentoId;
        //    modificable.Telefono = entidad.Telefono;
        //    modificable.Domicilio = entidad.Domicilio;


        //    try
        //    {
        //        context.Personas.Update(modificable);
        //        await context.SaveChangesAsync();
        //        return Ok();

        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }

        //}


        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult> Delete(int id)
        //{

        //    var existe = await context.Personas.AnyAsync(x => x.Id == id);

        //    if (!existe)
        //    {
        //        return NotFound($"La persona {id} que intenta borrar no existe");
        //    }

        //    Persona BorrarEntidad = new Persona();
        //    BorrarEntidad.Id = id;

        //    context.Remove(BorrarEntidad);

        //    await context.SaveChangesAsync();
        //    return Ok();
        //}
        #endregion

        #region controller TipoDocumento

        ////CONTROLLER TIPO DOCUMENTO
        //private readonly Context context;

        //public ControllerTipoDocumento(Context context)
        //{
        //    this.context = context;
        //}


        //[HttpGet]
        //public async Task<ActionResult<List<TipoDocumento>>> Get()
        //{
        //    return await context.TiposDocumento.ToListAsync();
        //}

        ////-------------
        ////Método Get por ID
        ////-------------

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<TipoDocumento>> Get(int id)
        //{
        //    TipoDocumento? pepe = await context.TiposDocumento
        //        .FirstOrDefaultAsync(x => x.Id == id);

        //    if (pepe == null)
        //    {
        //        return NotFound("No se encontro el tipo de documento solicitado");
        //    }

        //    return pepe;
        //}

        //[HttpPost]
        //public async Task<ActionResult<int>> Post(TipoDocumento entidad)
        //{
        //    try
        //    {
        //        context.TiposDocumento.Add(entidad);
        //        await context.SaveChangesAsync();
        //        return entidad.Id;
        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }
        //}


        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(int id, [FromBody] TipoDocumento entidad)
        //{
        //    if (id == entidad.Id)
        //    {
        //        return BadRequest("Datos incorrectos");
        //    }

        //    var modificable = await context.TiposDocumento
        //        .Where(reg => reg.Id == id).FirstOrDefaultAsync();

        //    if (modificable == null)
        //    {
        //        return NotFound("No se encontro el tipo de documento solicitado");
        //    }

        //    modificable.Nombre = entidad.Nombre;
        //    modificable.Codigo = entidad.Codigo;



        //    try
        //    {
        //        context.TiposDocumento.Update(modificable);
        //        await context.SaveChangesAsync();
        //        return Ok();

        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }

        //}


        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult> Delete(int id)
        //{

        //    var existe = await context.TiposDocumento.AnyAsync(x => x.Id == id);

        //    if (!existe)
        //    {
        //        return NotFound($"El tipo de documento {id} que intenta borrar no existe");
        //    }

        //    TipoDocumento BorrarEntidad = new TipoDocumento();
        //    BorrarEntidad.Id = id;

        //    context.Remove(BorrarEntidad);

        //    await context.SaveChangesAsync();
        //    return Ok();
        //}
        #endregion

        #region controller Clase

        ////CONTROLLER CLASE

        //private readonly Context context;

        //public ControllerClase(Context context)
        //{
        //    this.context = context;
        //}


        //[HttpGet]
        //public async Task<ActionResult<List<Clase>>> Get()
        //{
        //    return await context.Clases.ToListAsync();
        //}

        ////-------------
        ////Método Get por ID
        ////-------------

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<Clase>> Get(int id)
        //{
        //    Clase? pepe = await context.Clases
        //        .FirstOrDefaultAsync(x => x.Id == id);

        //    if (pepe == null)
        //    {
        //        return NotFound("No se encontro la clase solicitada");
        //    }

        //    return pepe;
        //}

        //[HttpPost]
        //public async Task<ActionResult<int>> Post(Clase entidad)
        //{
        //    try
        //    {
        //        context.Clases.Add(entidad);
        //        await context.SaveChangesAsync();
        //        return entidad.Id;
        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }
        //}


        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(int id, [FromBody] Clase entidad)
        //{
        //    if (id == entidad.Id)
        //    {
        //        return BadRequest("Datos incorrectos");
        //    }

        //    var modificable = await context.Clases
        //        .Where(reg => reg.Id == id).FirstOrDefaultAsync();

        //    if (modificable == null)
        //    {
        //        return NotFound("No se encontro la clase solicitada");
        //    }

        //    modificable.TurnoId = entidad.TurnoId;
        //    modificable.Fecha = entidad.Fecha;



        //    try
        //    {
        //        context.Clases.Update(modificable);
        //        await context.SaveChangesAsync();
        //        return Ok();

        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }

        //}


        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult> Delete(int id)
        //{

        //    var existe = await context.Clases.AnyAsync(x => x.Id == id);

        //    if (!existe)
        //    {
        //        return NotFound($"La clase {id} que intenta borrar no existe");
        //    }

        //    Clase BorrarEntidad = new Clase();
        //    BorrarEntidad.Id = id;

        //    context.Remove(BorrarEntidad);

        //    await context.SaveChangesAsync();
        //    return Ok();
        //}
        #endregion

        #region controller Evaluacion

        ////CONTROLLER EVALUACION

        //private readonly Context context;

        //public ControllerEvaluacion(Context context)
        //{
        //    this.context = context;
        //}


        //[HttpGet]
        //public async Task<ActionResult<List<Evaluacion>>> Get()
        //{
        //    return await context.Evaluaciones.ToListAsync();
        //}

        ////-------------
        ////Método Get por ID
        ////-------------

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<Evaluacion>> Get(int id)
        //{
        //    Evaluacion? pepe = await context.Evaluaciones
        //        .FirstOrDefaultAsync(x => x.Id == id);

        //    if (pepe == null)
        //    {
        //        return NotFound("No se encontro la evaluacion solicitada");
        //    }

        //    return pepe;
        //}

        //[HttpPost]
        //public async Task<ActionResult<int>> Post(Evaluacion entidad)
        //{
        //    try
        //    {
        //        context.Evaluaciones.Add(entidad);
        //        await context.SaveChangesAsync();
        //        return entidad.Id;
        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }
        //}


        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(int id, [FromBody] Evaluacion entidad)
        //{
        //    if (id == entidad.Id)
        //    {
        //        return BadRequest("Datos incorrectos");
        //    }

        //    var modificable = await context.Evaluaciones
        //        .Where(reg => reg.Id == id).FirstOrDefaultAsync();

        //    if (modificable == null)
        //    {
        //        return NotFound("No se encontro la evaluacion solicitada");
        //    }

        //    modificable.TurnoId = entidad.TurnoId;
        //    modificable.Fecha = entidad.Fecha;
        //    modificable.TipoEvaluacion = entidad.TipoEvaluacion;
        //    modificable.Folio = entidad.Folio;
        //    modificable.Libro = entidad.Libro;
        //    modificable.Sede = entidad.Sede;



        //    try
        //    {
        //        context.Evaluaciones.Update(modificable);
        //        await context.SaveChangesAsync();
        //        return Ok();

        //    }
        //    catch (Exception err)
        //    {

        //        return BadRequest(err.Message);
        //    }

        //}


        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult> Delete(int id)
        //{

        //    var existe = await context.Evaluaciones.AnyAsync(x => x.Id == id);

        //    if (!existe)
        //    {
        //        return NotFound($"La evaluacion {id} que intenta borrar no existe");
        //    }

        //    Evaluacion BorrarEntidad = new Evaluacion();
        //    BorrarEntidad.Id = id;

        //    context.Remove(BorrarEntidad);

        //    await context.SaveChangesAsync();
        //    return Ok();
        //}
        #endregion
    }
}
