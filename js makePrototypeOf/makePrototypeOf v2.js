function makePrototypeOf(proto) {
    let base = [proto].constrainedWith(Object) ? proto : null;
    if (base == null) {
        Object.setPrototypeOf(this, null);
    } else {
        let basis = new Object().makePrototypeOf(Object.getPrototypeOf(base));
        Object.keys(base).forEach((key) => {
            let descriptor = Object.getOwnPropertyDescriptor(base, key);
            if (descriptor.hasOwnProperty('value')) {
                defineSharedProperty(this, key, () => {
                    return proto[key];
                }, (value) => {
                proto[key] = value;
                });
            } else {
                let getter = descriptor.get;
                let setter = descriptor.set;
                defineSharedProperty(this, key, getter == undefined ? undefined : () => {
                    return getter.call(proto);
                }, setter == undefined ? undefined : (value) => {
                    setter.call(proto, value);
                });
            }
        });
        Object.setPrototypeOf(this, basis);
    }
    return this;
}