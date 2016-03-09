Why using MemberwiseClone?

MSDN Remarks:
The MemberwiseClone method creates a shallow copy by creating a new object, and then copying the nonstatic fields of the current object to the new object. If a field is a value type, a bit-by-bit copy of the field is performed. If a field is a reference type, the reference is copied but the referred object is not; therefore, the original object and its clone refer to the same object.

Docs:
https://msdn.microsoft.com/en-us/library/system.object.memberwiseclone.aspx