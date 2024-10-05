// Generated from c:/Users/Ng Bob Shoaun/Documents/Bob-Lang/ConsoleApp1/frontend/BobLang.g4 by ANTLR 4.13.1
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
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NEWLINE=7, BOOL=8, ID=9, 
		INT=10, CHAR=11, WS=12, COMMENT=13;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "NEWLINE", "BOOL", "ID", 
			"INT", "CHAR", "WS", "COMMENT"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'*'", "'/'", "'+'", "'-'", "'('", "')'"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, "NEWLINE", "BOOL", "ID", "INT", 
			"CHAR", "WS", "COMMENT"
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
	public String getGrammarFileName() { return "BobLang.g4"; }

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
		"\u0004\u0000\rc\u0006\uffff\uffff\u0002\u0000\u0007\u0000\u0002\u0001"+
		"\u0007\u0001\u0002\u0002\u0007\u0002\u0002\u0003\u0007\u0003\u0002\u0004"+
		"\u0007\u0004\u0002\u0005\u0007\u0005\u0002\u0006\u0007\u0006\u0002\u0007"+
		"\u0007\u0007\u0002\b\u0007\b\u0002\t\u0007\t\u0002\n\u0007\n\u0002\u000b"+
		"\u0007\u000b\u0002\f\u0007\f\u0001\u0000\u0001\u0000\u0001\u0001\u0001"+
		"\u0001\u0001\u0002\u0001\u0002\u0001\u0003\u0001\u0003\u0001\u0004\u0001"+
		"\u0004\u0001\u0005\u0001\u0005\u0001\u0006\u0004\u0006)\b\u0006\u000b"+
		"\u0006\f\u0006*\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001"+
		"\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0001\u0007\u0003\u00076\b"+
		"\u0007\u0001\b\u0001\b\u0005\b:\b\b\n\b\f\b=\t\b\u0001\t\u0001\t\u0001"+
		"\t\u0005\tB\b\t\n\t\f\tE\t\t\u0003\tG\b\t\u0001\n\u0001\n\u0001\n\u0001"+
		"\n\u0001\n\u0001\n\u0001\n\u0003\nP\b\n\u0001\u000b\u0004\u000bS\b\u000b"+
		"\u000b\u000b\f\u000bT\u0001\u000b\u0001\u000b\u0001\f\u0001\f\u0001\f"+
		"\u0001\f\u0005\f]\b\f\n\f\f\f`\t\f\u0001\f\u0001\f\u0000\u0000\r\u0001"+
		"\u0001\u0003\u0002\u0005\u0003\u0007\u0004\t\u0005\u000b\u0006\r\u0007"+
		"\u000f\b\u0011\t\u0013\n\u0015\u000b\u0017\f\u0019\r\u0001\u0000\u0007"+
		"\u0002\u0000\n\n\r\r\u0002\u0000AZaz\u0004\u000009AZ__az\u0001\u00000"+
		"0\u0001\u000019\u0001\u000009\u0003\u0000\t\n\r\r  j\u0000\u0001\u0001"+
		"\u0000\u0000\u0000\u0000\u0003\u0001\u0000\u0000\u0000\u0000\u0005\u0001"+
		"\u0000\u0000\u0000\u0000\u0007\u0001\u0000\u0000\u0000\u0000\t\u0001\u0000"+
		"\u0000\u0000\u0000\u000b\u0001\u0000\u0000\u0000\u0000\r\u0001\u0000\u0000"+
		"\u0000\u0000\u000f\u0001\u0000\u0000\u0000\u0000\u0011\u0001\u0000\u0000"+
		"\u0000\u0000\u0013\u0001\u0000\u0000\u0000\u0000\u0015\u0001\u0000\u0000"+
		"\u0000\u0000\u0017\u0001\u0000\u0000\u0000\u0000\u0019\u0001\u0000\u0000"+
		"\u0000\u0001\u001b\u0001\u0000\u0000\u0000\u0003\u001d\u0001\u0000\u0000"+
		"\u0000\u0005\u001f\u0001\u0000\u0000\u0000\u0007!\u0001\u0000\u0000\u0000"+
		"\t#\u0001\u0000\u0000\u0000\u000b%\u0001\u0000\u0000\u0000\r(\u0001\u0000"+
		"\u0000\u0000\u000f5\u0001\u0000\u0000\u0000\u00117\u0001\u0000\u0000\u0000"+
		"\u0013F\u0001\u0000\u0000\u0000\u0015O\u0001\u0000\u0000\u0000\u0017R"+
		"\u0001\u0000\u0000\u0000\u0019X\u0001\u0000\u0000\u0000\u001b\u001c\u0005"+
		"*\u0000\u0000\u001c\u0002\u0001\u0000\u0000\u0000\u001d\u001e\u0005/\u0000"+
		"\u0000\u001e\u0004\u0001\u0000\u0000\u0000\u001f \u0005+\u0000\u0000 "+
		"\u0006\u0001\u0000\u0000\u0000!\"\u0005-\u0000\u0000\"\b\u0001\u0000\u0000"+
		"\u0000#$\u0005(\u0000\u0000$\n\u0001\u0000\u0000\u0000%&\u0005)\u0000"+
		"\u0000&\f\u0001\u0000\u0000\u0000\')\u0007\u0000\u0000\u0000(\'\u0001"+
		"\u0000\u0000\u0000)*\u0001\u0000\u0000\u0000*(\u0001\u0000\u0000\u0000"+
		"*+\u0001\u0000\u0000\u0000+\u000e\u0001\u0000\u0000\u0000,-\u0005t\u0000"+
		"\u0000-.\u0005r\u0000\u0000./\u0005u\u0000\u0000/6\u0005e\u0000\u0000"+
		"01\u0005f\u0000\u000012\u0005a\u0000\u000023\u0005l\u0000\u000034\u0005"+
		"s\u0000\u000046\u0005e\u0000\u00005,\u0001\u0000\u0000\u000050\u0001\u0000"+
		"\u0000\u00006\u0010\u0001\u0000\u0000\u00007;\u0007\u0001\u0000\u0000"+
		"8:\u0007\u0002\u0000\u000098\u0001\u0000\u0000\u0000:=\u0001\u0000\u0000"+
		"\u0000;9\u0001\u0000\u0000\u0000;<\u0001\u0000\u0000\u0000<\u0012\u0001"+
		"\u0000\u0000\u0000=;\u0001\u0000\u0000\u0000>G\u0007\u0003\u0000\u0000"+
		"?C\u0007\u0004\u0000\u0000@B\u0007\u0005\u0000\u0000A@\u0001\u0000\u0000"+
		"\u0000BE\u0001\u0000\u0000\u0000CA\u0001\u0000\u0000\u0000CD\u0001\u0000"+
		"\u0000\u0000DG\u0001\u0000\u0000\u0000EC\u0001\u0000\u0000\u0000F>\u0001"+
		"\u0000\u0000\u0000F?\u0001\u0000\u0000\u0000G\u0014\u0001\u0000\u0000"+
		"\u0000HI\u0005\'\u0000\u0000IJ\t\u0000\u0000\u0000JP\u0005\'\u0000\u0000"+
		"KL\u0005\'\u0000\u0000LM\u0005\\\u0000\u0000MN\t\u0000\u0000\u0000NP\u0005"+
		"\'\u0000\u0000OH\u0001\u0000\u0000\u0000OK\u0001\u0000\u0000\u0000P\u0016"+
		"\u0001\u0000\u0000\u0000QS\u0007\u0006\u0000\u0000RQ\u0001\u0000\u0000"+
		"\u0000ST\u0001\u0000\u0000\u0000TR\u0001\u0000\u0000\u0000TU\u0001\u0000"+
		"\u0000\u0000UV\u0001\u0000\u0000\u0000VW\u0006\u000b\u0000\u0000W\u0018"+
		"\u0001\u0000\u0000\u0000XY\u0005/\u0000\u0000YZ\u0005/\u0000\u0000Z^\u0001"+
		"\u0000\u0000\u0000[]\b\u0000\u0000\u0000\\[\u0001\u0000\u0000\u0000]`"+
		"\u0001\u0000\u0000\u0000^\\\u0001\u0000\u0000\u0000^_\u0001\u0000\u0000"+
		"\u0000_a\u0001\u0000\u0000\u0000`^\u0001\u0000\u0000\u0000ab\u0006\f\u0000"+
		"\u0000b\u001a\u0001\u0000\u0000\u0000\t\u0000*5;CFOT^\u0001\u0006\u0000"+
		"\u0000";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}