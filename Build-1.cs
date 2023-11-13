using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using System;
using Uno.Extensions.Markup;
using Uno.Toolkit.UI;

namespace SIMBA.UI;

public partial class BUILD : Page
{
	public BUILD()
	{
		this
			.Background(Theme.Brushes.Background.Default)
			.NavigationCacheMode(NavigationCacheMode.Required)
			.Content
			(
				new AutoLayout()
					.Children
					(
						new AutoLayout()
							.Margin(989,610.5471,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(110.279106)
							.Height(38.323948)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new AutoLayout()
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(110.279106)
									.Height(38.323948)
									.AutoLayout(isIndependentLayout: true)
									.Children
									(
										new Rectangle()
											.RadiusX(32)
											.RadiusY(32)
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(110.279106)
											.Height(38.323948)
											.AutoLayout(isIndependentLayout: true),
										new AutoLayout()
											.Margin(16.424683,6.257141,0,0)
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(16.42455)
											.Height(25.95748)
											.AutoLayout(isIndependentLayout: true)
											.Children
											(
												new Path()
													.Data("F1 M 16.423047086404345 6.678342362567117 C 16.423047086404345 6.639289732852669 16.413283979941784 6.60173945516522 16.398263816153232 6.567944125030163 C 16.393757862989773 6.558932024006738 16.386247733108945 6.551421939820551 16.380990627796397 6.542409838797126 C 16.36672161687315 6.519128529117159 16.351701357111487 6.4981003420986205 16.33142408729417 6.480076140051771 C 16.32842005453646 6.477071914072913 16.326917845853284 6.473317064284202 16.323914005399896 6.470313030609727 L 8.3805003858234 0.059705094793575796 C 8.282118267170473 -0.019901700174438437 8.141679827423301 -0.019901700174438437 8.043297708770375 0.059705094793575796 L 0.0991330810044528 6.470313030609727 C 0.09612924055106613 6.472566103852152 0.09462703186788676 6.477071914072913 0.09162299911017607 6.480076140051771 C 0.07134572929285783 6.497349189004079 0.05632551823396775 6.519128481846808 0.04280746679737735 6.541658830378507 C 0.03679940128195597 6.550670931401932 0.029289223414571533 6.558181063574688 0.0247832702511132 6.567944125030163 C 0.009763106462559745 6.60173945516522 0 6.638538773136836 0 6.678342362567117 L 0 9.29260266777894 C 0 9.29785977469584 0.002253024568283018 9.30161491312018 0.002253024568283018 9.306871827732696 C 0.003003984681629686 9.325647182874087 0.009012002300024368 9.342920231826396 0.013518147409698108 9.360944433873245 C 0.01802429251937185 9.376715755340161 0.02102808534431328 9.392486787455232 0.02778730300882389 9.407506955827607 C 0.03529728892999291 9.421776164484148 0.045060347405998805 9.4337923464524 0.054823597828220105 9.4473104020144 C 0.06608876865618905 9.462330570386776 0.07660278661885153 9.477350594083227 0.0908719909207484 9.490117881875667 C 0.09387602367845908 9.493121723245759 0.09612909623329596 9.497627966061856 0.09988408919388048 9.500631999736331 L 1.3157663478772825 10.48220000287102 L 0.09988408919388048 11.463768006005708 C 0.09612909623329596 11.466772231984566 0.09462703186788676 11.471278090191895 0.09162299911017607 11.47428212386637 C 0.07134572929285783 11.491555366197387 0.05632551823396775 11.513334657607682 0.04280746679737735 11.535864814193108 C 0.03679940128195597 11.544877107162806 0.029289223414571533 11.552387047389288 0.0247832702511132 11.562150108844763 C 0.009763106462559745 11.595194479263988 0 11.632744900194925 0 11.671797337963099 L 0 14.28680865159354 C 0 14.29131479807839 0.002253024568283018 14.295820656643828 0.002253024568283018 14.300326803128678 C 0.003003984681629686 14.319101964891361 0.009012002300024368 14.337126215640996 0.013518147409698108 14.355150417687845 C 0.01802429251937185 14.370921545776053 0.02102808534431328 14.386692915945755 0.02778730300882389 14.400961931223588 C 0.03454632872711909 14.415982099595963 0.045060347405998805 14.42799808961794 0.054823597828220105 14.440765377410381 C 0.06608876865618905 14.456536505498589 0.07660278661885153 14.471556771276536 0.0908719909207484 14.484323865690268 C 0.09387602367845908 14.487327899364743 0.09612909623329596 14.491833757572072 0.09988408919388048 14.49483798355093 L 1.315015339687855 15.475654978267 L 0.09988408919388048 16.45722298140169 C 0.09612909623329596 16.459476054644114 0.09537799207076059 16.463982057169257 0.09162299911017607 16.466986090843733 C 0.07209688215816429 16.485010292890582 0.05632551823396775 16.506038624585045 0.04280746679737735 16.52856878117047 C 0.03679940128195597 16.53758107414017 0.029289223414571533 16.545091014366648 0.0247832702511132 16.554854075822124 C 0.009763106462559745 16.58864940595718 0 16.625448915875072 0 16.66525231335908 L 0 19.280263626989523 C 0 19.284769773474373 0.0022530726443640227 19.288524671607757 0.003004032757710691 19.293781778524657 C 0.003755185175381377 19.31255694028734 0.009012050286578222 19.32983018261836 0.014269155599125782 19.347854384665208 C 0.018024340864034313 19.364376473901682 0.021028133330867133 19.37939693019347 0.028538311198251565 19.39441690661957 C 0.03529733691654677 19.40868611527611 0.04506039539255266 19.42145325839263 0.05557460601764778 19.434220352806364 C 0.06683977684561672 19.44999148089457 0.07735374753794258 19.46426078552425 0.0908719909207484 19.47777884108625 C 0.09462698388133291 19.480782874760724 0.09612909623329596 19.485288877285868 0.09988408919388048 19.487541950528293 L 8.043297708770375 25.89814981185783 C 8.056064799287874 25.908663833745358 8.07033409956288 25.913169884257066 8.08385215099947 25.92068006441639 C 8.094366361624564 25.926688131765342 8.104129372114016 25.934198311924668 8.116145503144859 25.938704266463244 C 8.146936982154838 25.950720401161142 8.17998115054344 25.95747947692871 8.212274551391602 25.95747947692871 C 8.24531891172642 25.95747947692871 8.277612312574579 25.950720401161142 8.308403599638343 25.938704266463244 C 8.320419730669185 25.933447159546343 8.330182789145193 25.926688131765342 8.341447959973161 25.92068006441639 C 8.35421505049066 25.913169884257066 8.369235262981986 25.908663833745358 8.381251394012828 25.89814981185783 L 16.32466501358932 19.487541950528293 C 16.328420006549905 19.485288877285868 16.329922263219636 19.480782874760724 16.332926103673024 19.47777884108625 C 16.34719530797492 19.46426078552425 16.357709517883798 19.449240521178737 16.368974496765553 19.434220352806364 C 16.378737747187774 19.42070210529809 16.38925157392044 19.40868611527611 16.39601079158495 19.39441690661957 C 16.402769817303245 19.380147891341736 16.405773994020617 19.364376521172034 16.410279947184076 19.348605393083826 C 16.415537052496624 19.330581191036977 16.420043149798797 19.31255694028734 16.42154507002549 19.293781778524657 C 16.42154507002549 19.288524671607757 16.423798094593774 19.284769773474373 16.423798094593774 19.280263626989523 L 16.423798094593774 16.66525231335908 C 16.423798094593774 16.625448915875072 16.414786140996522 16.58864940595718 16.39901482434266 16.554854075822124 C 16.3945088711792 16.545841974798698 16.38699854899405 16.538331890612515 16.381741635985826 16.52931978958909 C 16.36747243168393 16.506038479909122 16.352452365300916 16.485010292890582 16.3321750954836 16.466986090843733 C 16.329171062725887 16.463982057169257 16.327669046347033 16.459476054644114 16.32466501358932 16.45722298140169 L 15.108782754905919 15.475654978267 L 16.32466501358932 14.49483798355093 C 16.328420006549905 14.491833757572072 16.329922263219636 14.487327899364743 16.332926103673024 14.484323865690268 C 16.34719530797492 14.471556771276536 16.357709517883798 14.456536505498589 16.368974496765553 14.440765377410381 C 16.378737747187774 14.42799808961794 16.38925157392044 14.41523113988013 16.39601079158495 14.400961931223588 C 16.403520777506117 14.386692915945755 16.405773994020617 14.370921545776053 16.410279947184076 14.355150417687845 C 16.415537052496624 14.337126215640996 16.420794109912144 14.319101964891361 16.42154507002549 14.300326803128678 C 16.42229603013884 14.295820656643828 16.424549102783203 14.29131479807839 16.424549102783203 14.28680865159354 L 16.424549102783203 11.671797337963099 C 16.424549102783203 11.632744900194925 16.414785996320642 11.595194479263988 16.39976583253209 11.562150108844763 C 16.39450872721954 11.552387047389288 16.38699859733871 11.544877107162806 16.38249264417525 11.535864814193108 C 16.368223439873354 11.513334657607682 16.35320337349034 11.491555317494601 16.332926103673024 11.473531115447752 C 16.32917111071244 11.470527081773277 16.328420006549905 11.466772231984566 16.32466501358932 11.463768006005708 L 15.108782754905919 10.48220000287102 L 16.32466501358932 9.500631999736331 C 16.328420006549905 9.497627966061856 16.32992211890187 9.493121723245759 16.333677111862453 9.490117881875667 C 16.34794631616435 9.477350594083227 16.358460334127013 9.462330570386776 16.36972550495498 9.4473104020144 C 16.378737603228114 9.4337923464524 16.389251621906993 9.421776164484148 16.396761799774378 9.407506955827607 C 16.403520825492674 9.392486787455232 16.406525002210046 9.377466570380072 16.411030955373505 9.361695442291865 C 16.415537100483178 9.342920087150473 16.420794157988226 9.325647134171302 16.42229607821492 9.306120819314078 C 16.42229607821492 9.301614864775502 16.424549102783203 9.29785977469584 16.424549102783203 9.29260266777894 L 16.424549102783203 6.678342362567117 L 16.423047086404345 6.678342362567117 Z M 8.48038447501728 15.1429582488189 L 8.48038447501728 13.215870646643221 L 15.88682723915299 7.238594642856695 L 15.88682723915299 9.165682245032373 L 8.48038447501728 15.1429582488189 Z M 0.5362198472513583 9.165682245032373 L 0.5362198472513583 7.238594642856695 L 7.943413619576495 13.215870646643221 L 7.943413619576495 15.1429582488189 L 0.5362198472513583 9.165682245032373 Z M 8.211523543202173 0.6116962652891288 L 15.72836451118375 6.678342362567117 L 8.211523543202173 12.744237359750654 L 0.6946825752205973 6.678342362567117 L 8.211523543202173 0.6116962652891288 Z M 15.88682723915299 14.159137220428356 L 8.48038447501728 20.137164232633502 L 8.48038447501728 18.21007663045782 L 15.88682723915299 12.232800626671295 L 15.88682723915299 14.159137220428356 Z M 7.943413619576495 20.137164232633502 L 0.5362198472513583 14.159137220428356 L 0.5362198472513583 12.232800626671295 L 7.943413619576495 18.21007663045782 L 7.943413619576495 20.137164232633502 Z M 15.88682723915299 19.152592195824337 L 8.48038447501728 25.130619208029483 L 8.48038447501728 23.204282614272422 L 15.88682723915299 17.226255602067276 L 15.88682723915299 19.152592195824337 Z M 7.943413619576495 25.130619208029483 L 0.5362198472513583 19.152592195824337 L 0.5362198472513583 17.226255602067276 L 7.943413619576495 23.204282614272422 L 7.943413619576495 25.130619208029483 Z M 15.72836451118375 16.66525231335908 L 8.211523543202173 22.731898318961235 L 0.6946825752205973 16.66525231335908 L 1.741587991282773 15.820367842413 L 8.043297708770375 20.905445844880468 C 8.055313839801217 20.915959866767995 8.069583091373453 20.920465917279707 8.083101142810042 20.927976097439032 C 8.09436631363801 20.933984164787983 8.10337836392459 20.941494344947305 8.115394494955432 20.94600029948588 C 8.146936936316935 20.95801643418378 8.179230142354012 20.964775509951348 8.211523543202173 20.964775509951348 C 8.244567903536991 20.964775509951348 8.276861353087922 20.95801643418378 8.308403599638343 20.94600029948588 C 8.319668770466311 20.94074319256898 8.329431780955765 20.933984164787983 8.340696951783734 20.927976097439032 C 8.354215003220324 20.920465917279707 8.368484254792557 20.915959866767995 8.3805003858234 20.905445844880468 L 14.681459095121573 15.820367842413 L 15.72836451118375 16.66525231335908 Z M 15.72836451118375 11.671797337963099 L 8.211523543202173 17.738443343565255 L 0.6946825752205973 11.671797337963099 L 1.741587991282773 10.82691286701702 L 8.043297708770375 15.911990869484487 C 8.055313839801217 15.921753930939962 8.069583091373453 15.92701108584343 8.083101142810042 15.93377011362443 C 8.09436631363801 15.939778180973379 8.10337836392459 15.947288361132705 8.115394494955432 15.95179431567128 C 8.146936936316935 15.96381045036918 8.179230142354012 15.971320534555367 8.211523543202173 15.971320534555367 C 8.244567903536991 15.971320534555367 8.276861353087922 15.96381045036918 8.308403599638343 15.95179431567128 C 8.319668770466311 15.947288361132705 8.329431780955765 15.939778180973379 8.340696951783734 15.93377011362443 C 8.354215003220324 15.92701108584343 8.368484254792557 15.921753930939962 8.3805003858234 15.911990869484487 L 14.681459095121573 10.82691286701702 L 15.72836451118375 11.671797337963099 Z")
													.VerticalAlignment(VerticalAlignment.Stretch)
													.HorizontalAlignment(HorizontalAlignment.Stretch)
													.AutoLayout(isIndependentLayout: true),
												new Path()
													.Data("F1 M 6.925045490264893 3.4183628562145345 C 6.925045490264893 3.2704142641851037 6.804884346705531 3.151003896413655 6.656935606301704 3.151003896413655 C 6.508236098468499 3.151003896413655 6.388825722338515 3.2704142641851037 6.388825722338515 3.4183628562145345 C 6.388825722338515 4.791206054293207 5.075312593342387 5.90870642559576 3.4621472410932825 5.90870642559576 C 1.8489818888441782 5.90870642559576 0.5362197679263783 4.791206054293207 0.5362197679263783 3.4183628562145345 C 0.5362197679263783 2.0455196581358615 1.8489818888441782 0.9280193785091289 3.4621472410932825 0.9280193785091289 C 3.6942086914588197 0.9280193785091289 3.9232660636731485 0.9550557265176147 4.146315600450328 1.0008671849717279 L 4.102757131907289 1.013634326310534 C 3.960816650941143 1.0564417515084574 3.880458643316596 1.2058926495177889 3.9240172092651626 1.347082017747586 C 3.958563483462735 1.4627373897867073 4.065206773828772 1.5378381295156291 4.1801109639751 1.5378381295156291 C 4.206396295419353 1.5378381295156291 4.231930472676986 1.5340831359319538 4.258215804121239 1.5258219964908704 L 5.105352916475517 1.2704791697147497 C 5.106854836480025 1.2697282094767912 5.10760603686265 1.2689771050105658 5.109107956867159 1.2682261447726073 C 5.116618133623535 1.265973263969205 5.123377206328489 1.2614670699461805 5.130887191138678 1.258463036689991 C 5.152666570086055 1.249450936921422 5.175196571786952 1.238936628578511 5.19472287779658 1.22391665424381 C 5.1954738377988345 1.2231655017014957 5.195473933950982 1.2224145895396263 5.196224893953237 1.2216636293016678 C 5.197727006262041 1.2209124767593535 5.199228830114402 1.2194105082073474 5.200730942423206 1.2179085877314306 C 5.211996111584677 1.2088962960166143 5.218755184289631 1.1953783862965701 5.228518241321352 1.184113213599297 C 5.234526305947978 1.1781051470869177 5.240534322588058 1.1713459762873675 5.245791427122902 1.163835989120017 C 5.251048339353451 1.156325810006419 5.259309620519357 1.1495668791396778 5.263064612924452 1.1413057396985944 C 5.264566725233256 1.1398038192226776 5.264566677157182 1.1375507942805354 5.265317637159437 1.1360486815002626 C 5.2660687894659866 1.1345467610243458 5.267570709470495 1.133044600167984 5.2683216694727495 1.1322936399300254 C 5.274329734099376 1.1210284672327524 5.274329734099376 1.10826142186707 5.2773337664126885 1.096996249169797 C 5.278835878721493 1.0924902952586362 5.280337846802076 1.0894862620024464 5.2810888068043305 1.0849801161450383 C 5.28484399151372 1.0714620624653084 5.292353831827106 1.0586946804774762 5.2938559441359105 1.044425667186478 C 5.294606904138165 1.0414216339302884 5.293104791829361 1.0384176006740986 5.2938559441359105 1.035413567417909 C 5.295357864140419 1.0188912885357422 5.290852007974745 1.0023692975729466 5.289349895665941 0.9858470186907797 C 5.287847975661433 0.9700758927985632 5.288598791614519 0.9550556778148357 5.284092839117643 0.9400355115338874 C 5.284092839117643 0.939284551295929 5.284092839117643 0.9385333987536147 5.284092839117643 0.9370314782776978 C 5.283341686811093 0.9355295578017809 5.281839814882658 0.9347785013221174 5.281839814882658 0.9325254283934133 C 5.275831750256032 0.9145012288562754 5.264566533108015 0.8987299095853769 5.254052515984513 0.8814568630381892 C 5.248044451357886 0.8701916903409161 5.245040275084934 0.858175701275843 5.236779330182963 0.8476614889060555 L 5.2337752978696495 0.8439064473358184 L 5.233024289791321 0.843155439021771 L 4.641229924068652 0.10115922474292588 C 4.548855884596381 -0.014496147296195486 4.3806301667266405 -0.03402231762351844 4.264223868747865 0.058351750842223285 C 4.148568716361104 0.1499746677504495 4.129793325321579 0.3182007191784481 4.2214164082831545 0.4338559078659303 L 4.256713787964582 0.47816539839472777 C 3.996864901187213 0.4248439513408295 3.731008041459009 0.3940524672214174 3.4621472410932825 0.3940524672214174 C 1.5530848893344251 0.3940524672214174 0 1.751124399029275 0 3.419113864528582 C 0 5.0878545216935755 1.5530848893344251 6.444175720214845 3.4621472410932825 6.444175720214845 C 5.37196078428205 6.443424759976886 6.925045490264893 5.086352321713841 6.925045490264893 3.4183628562145345 Z")
													.Margin(4.750122,3.4838867,0,0)
													.VerticalAlignment(VerticalAlignment.Stretch)
													.HorizontalAlignment(HorizontalAlignment.Stretch)
													.AutoLayout(isIndependentLayout: true)
											),
										new TextBlock()
											.Text("Simulate")
											.Margin(43.798462,11.7323,0,0)
											.VerticalAlignment(VerticalAlignment.Center)
											.HorizontalAlignment(HorizontalAlignment.Center)
											.Width(53.96637)
											.Height(14.860306)
											.AutoLayout(isIndependentLayout: true)
									)
							),
						new AutoLayout()
							.Margin(1018.7207,561.27356,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(110.279106)
							.Height(38.323948)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new AutoLayout()
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(110.279106)
									.Height(38.323948)
									.AutoLayout(isIndependentLayout: true)
									.Children
									(
										new Rectangle()
											.RadiusX(32)
											.RadiusY(32)
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(110.279106)
											.Height(38.323948)
											.AutoLayout(isIndependentLayout: true),
										new AutoLayout()
											.Margin(17.206299,6.257141,0,0)
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(18.744543)
											.Height(24.23893)
											.AutoLayout(isIndependentLayout: true)
											.Children
											(
												new Ellipse()
													.Margin(0.7565918,7.0393066,0,0)
													.VerticalAlignment(VerticalAlignment.Stretch)
													.HorizontalAlignment(HorizontalAlignment.Stretch)
													.AutoLayout(isIndependentLayout: true),
												new Path()
													.Data("F1 M 12.954925537109375 1.6701041271069976 L 12.954925537109375 8.160277366638184 L 0 8.160277366638184 L 0 1.6701041271069976 C 0 1.0774580514864485 0.08153271753318758 0.5119899320138896 0.2156670259022575 0 C 0.7276570492255511 1.1046357279260777 1.5622706789155476 2.0470829821975105 2.5853741194019313 2.7203847818621774 C 3.340208849914038 3.2314980612541393 4.2019999744183165 3.609353359185309 5.144447443385921 3.7706652501451168 C 5.574904842412164 3.851321422888064 6.033416575503235 3.9047995812104452 6.491051376107623 3.9047995812104452 C 6.948686176712011 3.9047995812104452 7.4063208840802615 3.851321422888064 7.8376549358847765 3.7706652501451168 C 8.780102404852382 3.609353359185309 9.641893575974729 3.2314980612541393 10.395851653708563 2.7203847818621774 C 11.41983170035515 2.0470829821975105 12.25444486386446 1.130936705125719 12.766434887187755 0 C 12.874268225321126 0.5382908625954709 12.954925537109375 1.1046356813080176 12.954925537109375 1.6701041271069976 Z")
													.Margin(-0.00024414062,16.078674,0,0)
													.VerticalAlignment(VerticalAlignment.Stretch)
													.HorizontalAlignment(HorizontalAlignment.Stretch)
													.AutoLayout(isIndependentLayout: true),
												new Path()
													.Data("F1 M 15.001133918762207 8.348766870921212 L 10.82718724428876 13.304724567562785 C 10.450208158337583 13.76235948810759 10.018874169205112 14.139337741372332 9.588416716415221 14.462838172912598 C 9.911040596167624 13.27754642127819 9.884739657610519 12.038776474974776 9.534061533525483 10.853484723340369 C 9.292093635365699 9.96539265559082 8.860759809396491 9.12990240947855 8.268113787151671 8.403122044656808 C 7.998968484019317 8.053320865461135 7.6763445110307655 7.7298204106118344 7.325666386945729 7.4334975892483985 C 6.97586489243942 7.137174767884963 6.598885526779796 6.895206374368058 6.194729059165084 6.679539497704658 C 5.360115138760481 6.194727176764321 4.4439688169658655 5.925581983059491 3.554999620435376 5.844049391446589 C 2.3434067772428557 5.682737502046518 1.1046363426054662 5.871226838460187 0 6.4103943797541865 C 0.24284476082888268 5.898404471946051 0.5391675155518837 5.413592104387647 0.9161466015030614 4.982258117970514 L 5.063792104329034 0 L 10.018873842878591 4.147644431362236 L 10.046051807268055 4.174822018230034 L 15.001133918762207 8.348766870921212 Z")
													.Margin(3.743042,6.1035156E-05,0,0)
													.VerticalAlignment(VerticalAlignment.Stretch)
													.HorizontalAlignment(HorizontalAlignment.Stretch)
													.AutoLayout(isIndependentLayout: true)
											),
										new TextBlock()
											.Text("Build")
											.Margin(49.27417,10.949951,0,0)
											.VerticalAlignment(VerticalAlignment.Center)
											.HorizontalAlignment(HorizontalAlignment.Center)
											.Width(31.284853)
											.Height(14.860306)
											.AutoLayout(isIndependentLayout: true)
									)
							),
						new AutoLayout()
							.Margin(989,512,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(110.279106)
							.Height(38.323948)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new AutoLayout()
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(110.279106)
									.Height(38.323948)
									.AutoLayout(isIndependentLayout: true)
									.Children
									(
										new Rectangle()
											.RadiusX(32)
											.RadiusY(32)
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(110.279106)
											.Height(38.323948)
											.AutoLayout(isIndependentLayout: true),
										new TextBlock()
											.Text("Sketch")
											.Margin(50.055054,11.731628,0,0)
											.VerticalAlignment(VerticalAlignment.Center)
											.HorizontalAlignment(HorizontalAlignment.Center)
											.Width(42.234562)
											.Height(14.860306)
											.AutoLayout(isIndependentLayout: true),
										new AutoLayout()
											.Margin(17.206177,10.167603,0,0)
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(17.988796)
											.Height(20.304398)
											.AutoLayout(isIndependentLayout: true)
											.Children
											(
												new Path()
													.Data("F0 M 1.3496118383340139 0 L 16.639173766874908 0 L 17.98879623413086 8.097619977072942 L 8.99439811706543 20.304397583007812 L 0 8.097619977072942 L 1.3496118383340139 0 Z M 3.2412393972781897 2.232994714392763 L 2.3578655926718532 7.533298270337138 L 8.99439811706543 16.540015204472773 L 15.63097614070379 7.533298270337138 L 14.747601590208196 2.232994714392763 L 3.2412393972781897 2.232994714392763 Z")
													.VerticalAlignment(VerticalAlignment.Stretch)
													.HorizontalAlignment(HorizontalAlignment.Stretch)
													.AutoLayout(isIndependentLayout: true),
												new Path()
													.Data("F1 M 0 0 L 8.931965827941895 0 L 8.931965827941895 2.2329962253570557 L 0 2.2329962253570557 L 0 0 Z")
													.Margin(4.5288696,5.5826416,0,0)
													.VerticalAlignment(VerticalAlignment.Stretch)
													.HorizontalAlignment(HorizontalAlignment.Stretch)
													.AutoLayout(isIndependentLayout: true)
											)
									)
							),
						new AutoLayout()
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(1440.5)
							.Height(96)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new AutoLayout()
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(1440.5)
									.Height(96)
									.AutoLayout(isIndependentLayout: true)
									.Children
									(
										new AutoLayout()
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(1440.5)
											.Height(96)
											.AutoLayout(isIndependentLayout: true)
											.Children
											(
												new Rectangle()
													.Fill(ThemeResource.Get<Brush>(""))
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(1440)
													.Height(48)
													.AutoLayout(isIndependentLayout: true),
												new Path()
													.Data("F1 M 126 0 L 83 0 L 83 40 L 0 40 L 0 88 L 1440.5 88 L 1440.5 40 L 126 40 L 126 0 Z")
													.Fill(ThemeResource.Get<Brush>(""))
													.Margin(0,8,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(1440.5)
													.Height(88)
													.AutoLayout(isIndependentLayout: true),
												new Ellipse()
													.Margin(16,60,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(24)
													.Height(24)
													.AutoLayout(isIndependentLayout: true),
												new TextBlock()
													.Text("Ala Eswar")
													.Margin(48,65,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Foreground(ThemeResource.Get<Brush>(""))
													.AutoLayout(isIndependentLayout: true),
												new Rectangle()
													.Margin(48,94,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(89)
													.Height(2)
													.AutoLayout(isIndependentLayout: true),
												new Path()
													.Data("M 10 0 L 0 10 L 10 10 L 10 0 Z")
													.Fill(ThemeResource.Get<Brush>(""))
													.Margin(1334,78,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(10)
													.Height(10)
													.AutoLayout(isIndependentLayout: true),
												new Path()
													.Data("M 10 0 L 0 10 L 10 10 L 10 0 Z")
													.Fill(ThemeResource.Get<Brush>(""))
													.Margin(1286,78,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(10)
													.Height(10)
													.AutoLayout(isIndependentLayout: true),
												new AutoLayout()
													.Margin(16,18,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(52)
													.Height(12)
													.AutoLayout(isIndependentLayout: true)
													.Children
													(
														new Ellipse()
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(12)
															.Height(12)
															.AutoLayout(isIndependentLayout: true),
														new Ellipse()
															.Margin(20,0,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(12)
															.Height(12)
															.AutoLayout(isIndependentLayout: true),
														new Ellipse()
															.Margin(40,0,0,0)
															.VerticalAlignment(VerticalAlignment.Top)
															.HorizontalAlignment(HorizontalAlignment.Left)
															.Width(12)
															.Height(12)
															.AutoLayout(isIndependentLayout: true)
													),
												new Rectangle()
													.RadiusX(7)
													.RadiusY(7)
													.Margin(91,11,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(30)
													.Height(30)
													.AutoLayout(isIndependentLayout: true),
												new Image()
													.Source(new BitmapImage(new Uri("https://picsum.photos/23/23")))
													.Stretch(Stretch.UniformToFill)
													.Margin(93,17,0,0)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(23)
													.Height(23)
													.AutoLayout(isIndependentLayout: true)
											)
									)
							),
						new Rectangle()
							.RadiusX(10)
							.RadiusY(10)
							.Margin(1255,182,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(73)
							.Height(41)
							.AutoLayout(isIndependentLayout: true),
						new TextBlock()
							.Text("Save")
							.Margin(1273,193,129,812)
							.VerticalAlignment(VerticalAlignment.Center)
							.HorizontalAlignment(HorizontalAlignment.Center)
							.AutoLayout(isIndependentLayout: true),
						new Ellipse()
							.Margin(85,167,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(41)
							.Height(39.29168)
							.AutoLayout(isIndependentLayout: true),
						new Ellipse()
							.Margin(135,167,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(41)
							.Height(39.29168)
							.AutoLayout(isIndependentLayout: true),
						new AutoLayout()
							.Margin(94,175,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(24)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new Path()
									.Data("F1 M 0 0 L 7.199999809265137 0 C 7.199999809265137 0 10 0 10 3 C 10 6.375 7.199999809265137 6.375 7.199999809265137 6.375 L 6.399999618530273 6.375")
									.Margin(7,10.625,7,7)
									.VerticalAlignment(VerticalAlignment.Stretch)
									.HorizontalAlignment(HorizontalAlignment.Stretch)
									.AutoLayout(isIndependentLayout: true),
								new Path()
									.Data("F1 M 3.5 7 L 0 3.625 L 3.5 0")
									.Margin(7,7,13.5,10)
									.VerticalAlignment(VerticalAlignment.Stretch)
									.HorizontalAlignment(HorizontalAlignment.Stretch)
									.AutoLayout(isIndependentLayout: true),
								new Path()
									.Data("F1 M 10 20 C 15.522799968719482 20 20 15.522799968719482 20 10 C 20 4.477149963378906 15.522799968719482 0 10 0 C 4.477149963378906 0 0 4.477149963378906 0 10 C 0 15.522799968719482 4.477149963378906 20 10 20 Z")
									.Margin(2)
									.VerticalAlignment(VerticalAlignment.Stretch)
									.HorizontalAlignment(HorizontalAlignment.Stretch)
									.AutoLayout(isIndependentLayout: true)
							),
						new AutoLayout()
							.Margin(144,175,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(24)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new Path()
									.Data("F1 M 10 0 L 2.8000001907348633 0 C 2.8000001907348633 0 0 0 0 3 C 0 6.375 2.8000001907348633 6.375 2.8000001907348633 6.375 L 3.6000003814697266 6.375")
									.Margin(7,10.625,7,7)
									.VerticalAlignment(VerticalAlignment.Stretch)
									.HorizontalAlignment(HorizontalAlignment.Stretch)
									.AutoLayout(isIndependentLayout: true),
								new Path()
									.Data("F1 M 0 7 L 3.5 3.625 L 0 0")
									.Margin(13.5,7,7,10)
									.VerticalAlignment(VerticalAlignment.Stretch)
									.HorizontalAlignment(HorizontalAlignment.Stretch)
									.AutoLayout(isIndependentLayout: true),
								new Path()
									.Data("F1 M 10 20 C 15.522799968719482 20 20 15.522799968719482 20 10 C 20 4.477149963378906 15.522799968719482 0 10 0 C 4.477149963378906 0 0 4.477149963378906 0 10 C 0 15.522799968719482 4.477149963378906 20 10 20 Z")
									.Margin(2)
									.VerticalAlignment(VerticalAlignment.Stretch)
									.HorizontalAlignment(HorizontalAlignment.Stretch)
									.AutoLayout(isIndependentLayout: true)
							),
						new AutoLayout()
							.Margin(1197,561,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(103)
							.Height(27)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new Rectangle()
									.RadiusX(5)
									.RadiusY(5)
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(103)
									.Height(27)
									.AutoLayout(isIndependentLayout: true),
								new TextBlock()
									.Text("Hinge Joint")
									.Margin(5,4,0,0)
									.VerticalAlignment(VerticalAlignment.Center)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(94)
									.Height(19)
									.AutoLayout(isIndependentLayout: true)
							),
						new AutoLayout()
							.Margin(1197,594,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(139)
							.Height(27)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new Rectangle()
									.RadiusX(5)
									.RadiusY(5)
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(119)
									.Height(27)
									.AutoLayout(isIndependentLayout: true),
								new TextBlock()
									.Text("Choose Motor
")
									.Margin(5,4,0,0)
									.VerticalAlignment(VerticalAlignment.Center)
									.HorizontalAlignment(HorizontalAlignment.Center)
									.Width(134)
									.Height(19)
									.AutoLayout(isIndependentLayout: true)
							),
						new AutoLayout()
							.Margin(1197,627,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(113.21583)
							.Height(27)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new Rectangle()
									.RadiusX(5)
									.RadiusY(5)
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(109)
									.Height(27)
									.AutoLayout(isIndependentLayout: true),
								new TextBlock()
									.Text("Spring Joint
")
									.Margin(5,4,0,0)
									.VerticalAlignment(VerticalAlignment.Center)
									.HorizontalAlignment(HorizontalAlignment.Center)
									.Width(108.21583)
									.Height(19)
									.AutoLayout(isIndependentLayout: true)
							),
						new AutoLayout()
							.Margin(1197,660,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(148)
							.Height(27)
							.AutoLayout(isIndependentLayout: true)
							.Children
							(
								new AutoLayout()
									.VerticalAlignment(VerticalAlignment.Top)
									.HorizontalAlignment(HorizontalAlignment.Left)
									.Width(148)
									.Height(27)
									.AutoLayout(isIndependentLayout: true)
									.Children
									(
										new AutoLayout()
											.VerticalAlignment(VerticalAlignment.Top)
											.HorizontalAlignment(HorizontalAlignment.Left)
											.Width(148)
											.Height(27)
											.AutoLayout(isIndependentLayout: true)
											.Children
											(
												new Rectangle()
													.RadiusX(5)
													.RadiusY(5)
													.VerticalAlignment(VerticalAlignment.Top)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(103)
													.Height(27)
													.AutoLayout(isIndependentLayout: true),
												new TextBlock()
													.Text("Slider Joint
")
													.Margin(5,4,0,0)
													.VerticalAlignment(VerticalAlignment.Center)
													.HorizontalAlignment(HorizontalAlignment.Left)
													.Width(143)
													.Height(19)
													.AutoLayout(isIndependentLayout: true)
											)
									)
							),
						new TextBlock()
							.Text("Project six bar mech")
							.Margin(661,67,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Foreground(ThemeResource.Get<Brush>(""))
							.AutoLayout(isIndependentLayout: true),
						new TextBlock()
							.TextAlignment(TextAlignment.Center)
							.Text("Home")
							.Margin(1359,63,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Foreground(ThemeResource.Get<Brush>(""))
							.AutoLayout(isIndependentLayout: true),
						new Image()
							.Source(new BitmapImage(new Uri("https://picsum.photos/606/305")))
							.Stretch(Stretch.UniformToFill)
							.Margin(281,379,0,0)
							.VerticalAlignment(VerticalAlignment.Top)
							.HorizontalAlignment(HorizontalAlignment.Left)
							.Width(606)
							.Height(305.5)
							.AutoLayout(isIndependentLayout: true)
					)
			)
			;
	}
}