(async () => {
	/* [Array.prototype.bindTo].bindTo(instance = window) */
	(() => {
		let lock = { configurable: false, writable: false };
		Array.prototype.bindTo = function bindTo(instance = window) {
			this.forEach((value) => {
				if (value instanceof Function) {
					instance[value.name] = value;
					Object.defineProperty(instance, value.name, lock);
					if (value.prototype instanceof Object) {
						Object.defineProperty(value, 'prototype', lock);
						value.prototype.constructor = value;
						Object.defineProperty(value.prototype, 'constructor', lock);
					}
				}
			});
		};
		[Array.prototype.bindTo].bindTo(Array.prototype);
		let Nullable = function Nullable(type) {
			this.type = type;
			Object.defineProperty(this, 'type', lock);
		};
		[
			function toNullable() {
				return new Nullable(this);
			}
		].bindTo(Function.prototype);
		[
			function isNullable(container) {
				return container instanceof Nullable;
			},
			function removeNullable(container) {
				if (container instanceof Nullable) {
					return container.type;
				} else if (container instanceof Function) {
					return container;
				} else {
					throw 'The \'container\' argument should be either a \'Nullable\' type or a \'Function\' type.';
				}
			}
		].bindTo(window);
		[
			function constrainedWith(...types) {
				let arguments = Array.from(this);
				if (arguments.length != types.length) {
					return false;
				}
				let constrained = true;
				arguments.forEach((value, index) => {
					if (isNullable(types[index]) && value == null) {
						return;
					} else if (value instanceof removeNullable(types[index]) || Object.getPrototypeOf(value) == removeNullable(types[index]).prototype) {
						return;
					}
					constrained = false;
				});
				return constrained;
			},
			function constrainedWithAndThrow(...types) {
				if (!this.constrainedWith(...types)) {
					throw 'The function arguments should match up the parameter types.';
				}
			}
		].bindTo(Object.prototype);
	})();
	/* { control-flow } */
	(() => {
		let captured = 0;
		let getAccumulated = () => {
			return performance.now() - captured < 500 ? performance.now() - captured : 500;
		};
		let loop = [];
		setInterval(() => {
			loop = loop.filter((value) => {
				return value.callback != null;
			});
			loop.forEach((value) => {
				if (value.deferred < performance.now()) {
					value.callback.call(null);
					value.callback = null;
				}
			});
		}, 5);
		[
			function getCaptured() {
				return captured;
			},
			function captureSpan() {
				arguments.constrainedWithAndThrow();
				captured = performance.now();
			},
			function suspend() {
				arguments.constrainedWithAndThrow();
				if (getAccumulated() <= 25) {
					return new Promise((resolve) => {
						resolve();
					});
				}
				return mustSuspend();
			},
			function mustSuspend() {
				arguments.constrainedWithAndThrow();
				return new Promise((resolve) => {
					loop.push({
						deferred: performance.now() + getAccumulated(),
						callback: () => {
							captureSpan();
							resolve();
						}
					});
				});
			},
			function defer(timeout) {
				return new Promise((resolve) => {
					loop.push({
						deferred: performance.now() + timeout,
						callback: () => {
							resolve();
						}
					});
				});
			}
		].bindTo(window);
	})();
	await mustSuspend();
	/* { functionality } */
	let istream = [];
	let readed = 0;
	let counted = 0;
	[
		function write(content) {
			let consoleNode = document.querySelector('body > console');
			if (consoleNode == null) {
				return;
			}
			content.split('\n').forEach((value, index) => {
				let lastLineNode = consoleNode.querySelector(':scope > line:last-of-type');
				if (lastLineNode == null || index > 0) {
					lastLineNode = document.createElement('line');
					consoleNode.append(lastLineNode);
				}
				let lastSpanNode = lastLineNode.querySelector(':scope > span:last-of-type');
				if (lastSpanNode == null || lastSpanNode.getAttribute('foreground') != consoleNode.getAttribute('foreground') || lastSpanNode.getAttribute('background') != consoleNode.getAttribute('background')) {
					lastSpanNode = document.createElement('span');
					lastSpanNode.setAttribute('foreground', consoleNode.getAttribute('foreground'));
					lastSpanNode.setAttribute('background', consoleNode.getAttribute('background'));
					lastLineNode.append(lastSpanNode);
				}
				lastSpanNode.textContent += value;
			});
		},
		async function read() {
			let capturedCounted = counted;
			counted++;
			while (readed >= istream.length || capturedCounted != readed) {
				document.querySelector('body > console > input[type="text"]').readOnly = false;
				await defer(5);
			}
			let output = istream[readed++];
			if (readed == counted) {
				istream = [];
				readed = 0;
				counted = 0;
			}
			return output;
		},
		function pushInput(content) {
			istream.push(content + '\n');
		},
		function getForegroundColor() {
			return document.querySelector('body > console')?.getAttribute('foreground');
		},
		function getForegroundColor() {
			return document.querySelector('body > console')?.getAttribute('background');
		},
		function getTitle() {
			return document.title;
		},
		function setForegroundColor(color) {
			return document.querySelector('body > console')?.setAttribute('foreground', color);
		},
		function setForegroundColor(color) {
			return document.querySelector('body > console')?.setAttribute('background', color);
		},
		function setTitle(title) {
			document.title = title;
		},
		function clear() {
			document.querySelector('body > console')?.querySelectorAll(':scope > line').forEach((value) => {
				value.remove();
			});
			document.querySelector('body > console')?.append(document.createElement('line'));
		},
		function pressAnyKey() {
			document.querySelector('body > console')?.setAttribute('for-any-key');
		}
	].bindTo(window);
	/* { event-dispatcher } */
	let isLoaded = false;
	let structuredTag = async () => {
		let newConsoleNode = document.createElement('console');
		newConsoleNode.setAttribute('foreground', 'dark-white');
		newConsoleNode.setAttribute('background', 'black');
		let newInputNode = document.createElement('input');
		newInputNode.type = 'text';
		newInputNode.readOnly = true;
		newInputNode.addEventListener('keydown', function listener(e) {
			if (this.readOnly == true) {
				return;
			}
			let conduct = () => {
				pushInput(this.value);
				this.value = '';
				this.readOnly = true;
			};
			if (document.querySelector('body > console')?.hasAttribute('for-any-key')) {
				document.querySelector('body > console')?.removeAttribute('for-any-key');
				conduct();
			} else if (e.code == 'Enter') {
				conduct();
			}
		});
		newConsoleNode.append(newInputNode);
		document.body.append(newConsoleNode);
		clear();
		while(true) {
			let input = await read();
			write(input);
		}
	};
	let formedStyle = () => {
	};
	let delegate = () => {
		if (document.readyState == 'complete') {
			if (isLoaded == false) {
				structuredTag();
				isLoaded = true;
			}
			formedStyle();
		}
	};
	while (true) {
		await mustSuspend();
		delegate();
	}
})();