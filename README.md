namespace Quantum.QSharpApplication {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    
    @EntryPoint()
    operation HelloQ () : Unit {
        Message(Hello("Roman"));
    }


                                                // Comment   
    function Hello  (name : String) : String {  // Comment
        body (...) {                            // Comment
                                                // Comment
            return $"Hello, {name}!";           // Comment
        }                                       // Comment
    }                                           // Comment

    /// # Summary
    /// Given an operation and a target for that operation,
    /// applies the given operation twice.
    ///
    /// # Input
    /// ## op
    /// The operation to be applied.
    /// ## target
    /// The target to which the operation is to be applied.
    ///
    /// # Type Parameters
    /// ## 'T
    /// The type expected by the given operation as its input.
    ///
    /// # Example
    /// ```Q#
    /// // Should be equivalent to the identity.
    /// ApplyTwice(H, qubit);
    /// ```
    ///
    /// # See Also
    /// - Microsoft.Quantum.Intrinsic.H
    operation ApplyTwice<'T>(op : ('T => Unit), target : 'T) : Unit {
        op(target);
        op(target);
    }
}
