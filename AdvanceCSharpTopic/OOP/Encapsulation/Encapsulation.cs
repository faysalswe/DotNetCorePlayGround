/*
 * public => visible to everyone.
 * private => only visible containing class .
 * protected => only visible to containing class and inheritors.
 * internal => only visible to classes in the same assembly
 * protected internal => containing assembly public and other assembly as protected.
 * private protected => containing assembly protected and other assembly as private.
 */

namespace AdvanceCSharpTopic.OOP
{
    internal class Encapsulation: AccessModifires
    {
        EncapsulationClassInternal objInternal;
        EncapsulationClassProtected objProtected; 
        EncapsulationClassProtectedInternal objProtectedInternal; 
        EncapsulationClassPrivateProtected objPrivateProtected;
    }

    /* Can be done  */

    internal class ClassPublic1 : AccessModifires { }

    internal class ClassPublic2 : AccessModifires.EncapsulationClassInternal { }

    internal class ClassPublic3 : AccessModifires.EncapsulationClassProtectedInternal { }


    /* Can't be done */

    //public class ClassPublic1 : Encapsulation {}

    //public class ClassPublic2 : Encapsulation.EncapsulationClassInternal {}

    //public class ClassPublic3 : Encapsulation.EncapsulationClassProtectedInternal {}
}
