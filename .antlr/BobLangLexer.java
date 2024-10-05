// Generated from c:/Users/Ng Bob Shoaun/Documents/Bob-Lang/grammar.g4 by ANTLR 4.13.1
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast", "CheckReturnValue", "this-escape"})
public class BobLangLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.13.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		BOOL=1, ID=2, INT=3, CHAR=4, WS=5, COMMENT=6;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"BOOL", "ID", "INT", "CHAR", "WS", "COMMENT"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "BOOL", "ID", "INT", "CHAR", "WS", "COMMENT"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public BobLangLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "grammar.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\u0004\u0000\u0006D\u0006\uffff\uffff\u0002\u0000\u0007\u0000\u0002\u0001"+
		"\u0007\u0001\u0002\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004"+
		"\u0007\u0004\u0002\u0005\u0007\u0005\u0001\u0000\u0001\u0000\u0001\u0000"+
		"\u0001\u0000\u0001\u0000\u0001\u0000\u0001\u0000\u0001\u0000\u0001\u0000"+
		"\u0003\u0000\u0017\b\u0000\u0001\u0001\u0001\u0001\u0005\u0001\u001b\b"+
		"\u0001\n\u0001\f\u0001\u001e\t\u0001\u0001\u0002\u0001\u0002\u0001\u0002"+
		"\u0005\u0002#\b\u0002\n\u0002\f\u0002&\t\u0002\u0003\u0002(\b\u0002\u0001"+
		"\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001\u0003\u0001"+
		"\u0003\u0003\u00031\b\u0003\u0001\u0004\u0004\u00044\b\u0004\u000b\u0004"+
		"\f\u00045\u0001\u0004\u0001\u0004\u0001\u0005\u0001\u0005\u0001\u0005"+
		"\u0001\u0005\u0005\u0005>\b\u0005\n\u0005\f\u0005A\t\u0005\u0001\u0005"+
		"\u0001\u0005\u0000\u0000\u0006\u0001\u0001\u0003\u0002\u0005\u0003\u0007"+
		"\u0004\t\u0005\u000b\u0006\u0001\u0000\u0007\u0002\u0000AZaz\u0004\u0000"+
		"09AZ__az\u0001\u000000\u0001\u000019\u0001\u000009\u0003\u0000\t\n\r\r"+
		"  \u0002\u0000\n\n\r\rJ\u0000\u0001\u0001\u0000\u0000\u0000\u0000\u0003"+
		"\u0001\u0000\u0000\u0000\u0000\u0005\u0001\u0000\u0000\u0000\u0000\u0007"+
		"\u0001\u0000\u0000\u0000\u0000\t\u0001\u0000\u0000\u0000\u0000\u000b\u0001"+
		"\u0000\u0000\u0000\u0001\u0016\u0001\u0000\u0000\u0000\u0003\u0018\u0001"+
		"\u0000\u0000\u0000\u0005\'\u0001\u0000\u0000\u0000\u00070\u0001\u0000"+
		"\u0000\u0000\t3\u0001\u0000\u0000\u0000\u000b9\u0001\u0000\u0000\u0000"+
		"\r\u000e\u0005t\u0000\u0000\u000e\u000f\u0005r\u0000\u0000\u000f\u0010"+
		"\u0005u\u0000\u0000\u0010\u0017\u0005e\u0000\u0000\u0011\u0012\u0005f"+
		"\u0000\u0000\u0012\u0013\u0005a\u0000\u0000\u0013\u0014\u0005l\u0000\u0000"+
		"\u0014\u0015\u0005s\u0000\u0000\u0015\u0017\u0005e\u0000\u0000\u0016\r"+
		"\u0001\u0000\u0000\u0000\u0016\u0011\u0001\u0000\u0000\u0000\u0017\u0002"+
		"\u0001\u0000\u0000\u0000\u0018\u001c\u0007\u0000\u0000\u0000\u0019\u001b"+
		"\u0007\u0001\u0000\u0000\u001a\u0019\u0001\u0000\u0000\u0000\u001b\u001e"+
		"\u0001\u0000\u0000\u0000\u001c\u001a\u0001\u0000\u0000\u0000\u001c\u001d"+
		"\u0001\u0000\u0000\u0000\u001d\u0004\u0001\u0000\u0000\u0000\u001e\u001c"+
		"\u0001\u0000\u0000\u0000\u001f(\u0007\u0002\u0000\u0000 $\u0007\u0003"+
		"\u0000\u0000!#\u0007\u0004\u0000\u0000\"!\u0001\u0000\u0000\u0000#&\u0001"+
		"\u0000\u0000\u0000$\"\u0001\u0000\u0000\u0000$%\u0001\u0000\u0000\u0000"+
		"%(\u0001\u0000\u0000\u0000&$\u0001\u0000\u0000\u0000\'\u001f\u0001\u0000"+
		"\u0000\u0000\' \u0001\u0000\u0000\u0000(\u0006\u0001\u0000\u0000\u0000"+
		")*\u0005\'\u0000\u0000*+\t\u0000\u0000\u0000+1\u0005\'\u0000\u0000,-\u0005"+
		"\'\u0000\u0000-.\u0005\\\u0000\u0000./\t\u0000\u0000\u0000/1\u0005\'\u0000"+
		"\u00000)\u0001\u0000\u0000\u00000,\u0001\u0000\u0000\u00001\b\u0001\u0000"+
		"\u0000\u000024\u0007\u0005\u0000\u000032\u0001\u0000\u0000\u000045\u0001"+
		"\u0000\u0000\u000053\u0001\u0000\u0000\u000056\u0001\u0000\u0000\u0000"+
		"67\u0001\u0000\u0000\u000078\u0006\u0004\u0000\u00008\n\u0001\u0000\u0000"+
		"\u00009:\u0005/\u0000\u0000:;\u0005/\u0000\u0000;?\u0001\u0000\u0000\u0000"+
		"<>\b\u0006\u0000\u0000=<\u0001\u0000\u0000\u0000>A\u0001\u0000\u0000\u0000"+
		"?=\u0001\u0000\u0000\u0000?@\u0001\u0000\u0000\u0000@B\u0001\u0000\u0000"+
		"\u0000A?\u0001\u0000\u0000\u0000BC\u0006\u0005\u0000\u0000C\f\u0001\u0000"+
		"\u0000\u0000\b\u0000\u0016\u001c$\'05?\u0001\u0006\u0000\u0000";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}